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
        Debug.Log("Start �Լ� ����"); // 1�� ����

        AddMethod(3); // AddMethod �Լ� ����
    }

    private int AddMethod(int num1)
    {
        // && : �׸��� ( AND ���� )
        // || : �Ǵ� ( OR ����)

        return num1;
    }
}