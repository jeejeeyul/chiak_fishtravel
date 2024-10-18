using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mover : MonoBehaviour
{
    public GameObject player;//플레이어(물고기 참조)
                             //[Range(0f, 5f)]
    public int moveSpeed = 5;// 속도 지정
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");//상하좌우 입력 받아오기( 범위는 -1~1)
        Vector3 moveVelocity = new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
        this.transform.position += moveVelocity;// 이동자 이동

    }
}
