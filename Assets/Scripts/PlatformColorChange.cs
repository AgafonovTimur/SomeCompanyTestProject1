using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorChange : MonoBehaviour {

    [SerializeField]
    GameObject mainPanelWithScript;

    void OnEnable()
    {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0.64f, 0.64f, 0.64f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
 //       if (gameObject.name != "BottomPlatformSprite")
 //       {
 //           Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
 //           gameObject.GetComponent<SpriteRenderer>().color = rngColor;
 ////           Debug.Log(rngColor);
 //       }
        if (collision.gameObject.name == "basketball")
        {
            mainPanelWithScript.GetComponent<GameScore>().ChangeGameScore();
            Color rngColor = new Color(Random.Range(0.001f, 1), Random.Range(0.001f, 1), Random.Range(0.001f, 1));
            gameObject.GetComponent<SpriteRenderer>().color = rngColor;
        }
    }
}
