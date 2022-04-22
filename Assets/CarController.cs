using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float Speed = 0;
    Vector3 startPos;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)      
    {
        if (other.gameObject.tag == "flag" )  //깃발 게임오즈젝트를 tag한다 
        {
            other.gameObject.SetActive(false); // 비활성화
        }  
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //마우스를 클리한 좌표
            this.startPos = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스 버튼에서 손가락 떼었을때 좌표 
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //스와이프 길이를 처음 속도로 변경한다 
            this.Speed = swipeLength / 500.0f; 

        }

        transform.Translate(this.Speed, 0, 0); //이동
        this.Speed *= 0.96f; //감속 
    }
}
