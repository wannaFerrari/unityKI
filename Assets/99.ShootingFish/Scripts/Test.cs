using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //콘솔에 메시지를 띄울때
        Debug.Log("Hello World");
        MyDataContainer myData = new MyDataContainer();

        myData.a = 1;
        myData.b = 2;

        Debug.Log($"myData.a : {myData.a}, myData.b : {myData.b}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MyDataContainer
{
    public int a;
    public int b;
}
