using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject Distance;
    void Start()
    {
        this.car = GameObject.Find("Car");
        this.flag = GameObject.Find("flag");
        this.Distance = GameObject.Find("Distance");

    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.Distance.GetComponent<Text>().text = "��ǥ ��������" + length.ToString("F2") + "m";
        }
        else
        {
            this.Distance.GetComponent<Text>().text = "���� ����!";
        }

    }
    
}
