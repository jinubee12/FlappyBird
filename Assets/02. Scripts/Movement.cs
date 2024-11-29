using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private float h = 0f;
    private float v = 0f;

    public float rotSpeed = 30f;

    public Transform target;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0f, v).normalized;

        transform.position += dir * Time.deltaTime * moveSpeed; // ���� �̵�
        // transform.Translate(dir * Time.deltaTime * moveSpeed); // ���� �̵�

        if (h != 0 || v != 0) // W, A, S, D �� �ϳ��� ������ ���
        {
            // ĳ���Ͱ� �̵��Ϸ��� ������ �ٶ󺸰� �ϴ� �ڵ�
            Vector3 targetPos = transform.position + dir; // ��ǥ ��ġ
            transform.LookAt(targetPos); // ��ǥ ��ġ�� �ٶ󺸴� �ڵ�
            anim.SetBool("isWalk", true);
        }
        else anim.SetBool("isWalk", false);
    }
}