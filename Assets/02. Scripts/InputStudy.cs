using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputStudy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // W Ű
        {
            Debug.Log("W");
        }

        if (Input.GetKeyDown(KeyCode.S)) // S Ű
        {
            Debug.Log("S");
        }

        if (Input.GetKeyDown(KeyCode.Space)) // �����̽�Ű
        {
            Debug.Log("Space");
        }

        if (Input.GetKeyDown(KeyCode.Return)) // ����Ű
        {
            Debug.Log("Return");
        }

        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư�� ������ ����
        {
            Debug.Log("���콺 ���� ��ư�� ������ ����");
        }

        if (Input.GetMouseButton(0))  // ���콺 ���� ��ư�� ������ ��
        {
            Debug.Log("���콺 ���� ��ư�� ������ ��");
        }
    }
}