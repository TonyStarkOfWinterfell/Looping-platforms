﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{


    public int playerSpeed = 4;
    public bool facingRight = true;
    public int playerJumpPower = 225;
    public float moveX;
    public bool IsGrounded;
    



    void Update()
    {
        PlayerMove();        
    }

    void PlayerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded == true)
        {
            Jump();
        }




        






        //PLAYER DIRECTION
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }




        //COLLECTABLES
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Pickapple"))
            {
                Destroy(other.gameObject);
            }
        }
        {

        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        IsGrounded = false;

    }



    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }


    //PLAYER HITS FLOOR
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Player has collided with " + col.collider.name);
        if (col.gameObject.tag == "ground")
        {
            IsGrounded = true;
        }
    }

}
