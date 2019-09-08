using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1f;

    Vector3 mousePos;
    Vector3 touchPos;
    Vector2 dir;
    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.touchCount > 0)
            {
                Touch touch1Finger = Input.GetTouch(0);
                touchPos = Camera.main.ScreenToWorldPoint(touch1Finger.position);
                dir = (touchPos - transform.position).normalized;
                rb.velocity = new Vector2(dir.x * moveSpeed, dir.y * moveSpeed);
            }
        }
        //else //// edotor
        //{
        //    if (Input.GetMouseButton(0))
        //    {
        //        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //        dir = (mousePos - transform.position).normalized;
        //        rb.velocity = new Vector2(dir.x * moveSpeed, dir.y * moveSpeed);
        //    }
        //}
    }
}

