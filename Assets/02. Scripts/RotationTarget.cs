using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTarget : MonoBehaviour
{
    public Transform target;

    //public float rSpeed, raSpeed = 0f;
    public float rotSpeed = 0f;
    public float rotAroundSpeed = 0f;

    void Update()
    {
        // ����
        // �ڱ� �ڽ��� ȸ���ϴ� ��� -> Rotate
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);

        // ����
        // �ٸ� ����� �������� ȸ���ϴ� ��� -> RotateAround
        transform.RotateAround(target.position, Vector3.up, rotAroundSpeed * Time.deltaTime);
    }
}