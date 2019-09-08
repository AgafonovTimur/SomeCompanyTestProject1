using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnObject : MonoBehaviour { // click on platform
    //[SerializeField]
    //GameObject mainPanelWithScript;


    //private void Start()
    //{
    //    platform = gameObject.GetComponentInParent<GameObject>();
    //    Debug.Log(platform.name);
    //}

    private void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android) //android
        {
            if (Input.touchCount > 0)
            {
                Touch touch1Finger = Input.GetTouch(0);
                Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch1Finger.position);
                if (touch1Finger.phase == TouchPhase.Began)
                {
                    Collider2D hittedTargetCollider = Physics2D.OverlapPoint(touchPos);
                    if (hittedTargetCollider && hittedTargetCollider.name != "BottomPlatformSprite" && hittedTargetCollider.name != "basketball") 
                    {
                        GameObject hittedTargetGO = hittedTargetCollider.gameObject;
 //                       mainPanelWithScript.GetComponent<GameScore>().ChangeGameScore();
                        Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
                        hittedTargetGO.GetComponent<SpriteRenderer>().color = rngColor;
                        //Debug.Log("platform touched");
                        
                    }
                    ////       if (gameObject.name != "TouchDetection" && gameObject.name != "BottomPlatformSprite")
                    //       //            if (platform.name != "TouchDetection" && platform.name != "BottomPlatformSprite")
                    //       {
                    //           Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
                    //           platform.GetComponent<SpriteRenderer>().color = rngColor;
                    //           Debug.Log("platform touched");
                    //       }
                    //       else
                    //       {
                    //           Debug.Log("background or bottom touched");
                    //       }
                }
            }
        }
    }
    //void PlatformChangeColor(GameObject x)
    //{
    //    if (x.name != "BottomPlatformSprite");
    //    mainPanelWithScript.GetComponent<GameScore>().ChangeGameScore();
    //    Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
    //    x.GetComponent<SpriteRenderer>().color = rngColor;
    //    Debug.Log("platform touched");
        

    
}
    //private void OnMouseDown() // editor
    //{
    //    if (platform.name != "TouchDetection" && platform.name != "BottomPlatformSprite")
    //    {
    //        Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
    //        platform.GetComponent<SpriteRenderer>().color = rngColor;
    //        Debug.Log("platform touched");
    //    }
    //    else
    //    {
    //        Debug.Log("background or bottom touched");
    //    }
    //}

