using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("�����ΰ� ������ ���۵ƴ�.");
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("�����Ǵ� ���� ����ƴ�.");
    }
}