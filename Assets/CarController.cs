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
        if (other.gameObject.tag == "flag" )  //��� ���ӿ�����Ʈ�� tag�Ѵ� 
        {
            other.gameObject.SetActive(false); // ��Ȱ��ȭ
        }  
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //���콺�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            //���콺 ��ư���� �հ��� �������� ��ǥ 
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //�������� ���̸� ó�� �ӵ��� �����Ѵ� 
            this.Speed = swipeLength / 500.0f; 

        }

        transform.Translate(this.Speed, 0, 0); //�̵�
        this.Speed *= 0.96f; //���� 
    }
}
