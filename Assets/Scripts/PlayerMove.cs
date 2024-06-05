using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int moveSpeed = 5;
    private Rigidbody2D rigid;
    Vector2 move = new Vector2();
    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        move.x = Input.GetAxis("Horizontal");
        move.Normalize();

        rigid.velocity = move * moveSpeed;


    }
}
