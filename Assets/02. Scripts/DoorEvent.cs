using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("무엇인가 감지가 시작됐다.");
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("감지되던 것이 종료됐다.");
    }
}