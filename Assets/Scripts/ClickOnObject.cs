using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnObject : MonoBehaviour {
    [SerializeField]
    GameObject platform;

    //private void Start()
    //{
    //    platform = gameObject.GetComponentInParent<GameObject>();
    //    Debug.Log(platform.name);
    //}

    private void OnMouseDown()
    {
        if (platform.name != "TouchDetection" && platform.name != "BottomPlatformSprite")
        {
            Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
            platform.GetComponent<SpriteRenderer>().color = rngColor;
            Debug.Log("platform touched");
        }
        else
        {
            Debug.Log("background or bottom touched");
        }
    }
}
