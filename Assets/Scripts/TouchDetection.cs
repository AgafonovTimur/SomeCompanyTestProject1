using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1f;
    Vector2 touchPosition;
    [SerializeField]
    GameObject ball;
    Vector3 mousePos;
    Vector2 dir;
    Rigidbody2D rb;


    //private void OnMouseDown()
    //{
    //    if (Application.platform == RuntimePlatform.Android)
    //    {
    //        if (Input.touchCount > 0)
    //        {
    //            Touch touch1Finger = Input.GetTouch(0);
    //            touchPosition = Camera.main.ScreenToWorldPoint(touch1Finger.position);
    //            gameObject.transform.Translate(new Vector2(touchPosition.x, touchPosition.y) * Time.deltaTime * moveSpeed);
    //            Debug.Log("25");
    //        }
    //    }
    //}

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        //if (Application.platform == RuntimePlatform.Android)
        //{
            if (Input.GetMouseButton(0))
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                dir = (mousePos - transform.position).normalized;
                rb.velocity = new Vector2(dir.x * moveSpeed, dir.y * moveSpeed);
            }                

            //if (Input.touchCount > 0)
            //{
            //    Touch touch1Finger = Input.GetTouch(0);
            //    touchPosition = Camera.main.ScreenToWorldPoint(touch1Finger.position);
            //ball.transform.Translate(new Vector2(touchPosition.x, touchPosition.y)); // * moveSpeed);
            //    Debug.Log(touchPosition.x + " " + touchPosition.y);
            //}
   //}
    }
}


