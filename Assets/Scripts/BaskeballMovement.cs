using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaskeballMovement : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 1f;
    Vector2 speedY;
    float curPosX = 10f;
    float curPosy = 10f;
    Rigidbody2D ball_rb;
    float currGravity = 1f;
    
	
	void Start () {
        ball_rb = GetComponent<Rigidbody2D>();
	}

    public float setBallGravity(float x)
    {
   //     float y = Physics2D.gravity.y;
        currGravity = x;
        Debug.Log("sent gravity " + x + " " +currGravity);
        return x;
    }
    private void FixedUpdate()
    {
        speedY = (Vector2.up * moveSpeed) * currGravity;
        ball_rb.AddForce(speedY);
  //      Debug.Log(ball_rb + " " + currGravity);
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "BottomPlatform")
    //    { 
    //        ball_rb.AddForce((Vector2.up * speed) * curPosX);
    //        Debug.Log(collision.gameObject.tag);
    //    }
    //}
}
