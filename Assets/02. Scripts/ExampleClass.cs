using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public int number1 = 0;
    public int number2 = 0;

    void Start()
    {
        Debug.Log("Start 함수 실행"); // 1번 실행

        AddMethod(3); // AddMethod 함수 실행
    }

    private int AddMethod(int num1)
    {
        // && : 그리고 ( AND 연산 )
        // || : 또는 ( OR 연산)

        return num1;
    }
}