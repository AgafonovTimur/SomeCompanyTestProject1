using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasketballToTouchPox : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1f;
    Vector2 touchPosition;

    //private void OnMouseDown()
    //{
        
    //}


    //private void FIxedUpdate()
    //{
    //    if (Application.platform == RuntimePlatform.Android)
    //    {
    //        if (Input.touchCount > 0)
    //        {
    //            Touch touch1Finger = Input.GetTouch(0);
    //            touchPosition = Camera.main.ScreenToWorldPoint(touch1Finger.position);
    //            gameObject.transform.Translate(new Vector2(touchPosition.x, touchPosition.y) * Time.deltaTime * moveSpeed);
    //            Debug.Log(touchPosition);
    //        }
    //    }
    //}
}


