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

        transform.position += dir * Time.deltaTime * moveSpeed; // 월드 이동
        // transform.Translate(dir * Time.deltaTime * moveSpeed); // 로컬 이동

        if (h != 0 || v != 0) // W, A, S, D 중 하나라도 눌렀을 경우
        {
            // 캐릭터가 이동하려는 방향을 바라보게 하는 코드
            Vector3 targetPos = transform.position + dir; // 목표 위치
            transform.LookAt(targetPos); // 목표 위치를 바라보는 코드
            anim.SetBool("isWalk", true);
        }
        else anim.SetBool("isWalk", false);
    }
}