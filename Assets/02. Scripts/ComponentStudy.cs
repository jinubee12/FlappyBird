using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    public Transform destination; // ������ ������Ʈ

    void Start()
    {
        // �ڱ� �ڽ��� Transform�� ��ġ��       destination�� ��ġ�� �Ҵ��Ѵ�.
        // this.gameObject.transform.position = destination.position;
        transform.position = destination.position;
    }
}