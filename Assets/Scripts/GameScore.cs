using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {

    [SerializeField]
    GameObject gameScoreGO;

    public void ChangeGameScore ()
    {
        Text gameScore = gameScoreGO.GetComponent<Text>();
        int x = PlayerPrefs.GetInt("currentScore") + 1;
        PlayerPrefs.SetInt("currentScore", x);
        gameScore.text = " BallHit : " + x;
   //     Debug.Log("current score : " + PlayerPrefs.GetInt("currentScore"));
    }

	void Awake () {
 //       PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("currentScore") == 0)
        {
            PlayerPrefs.SetInt("currentScore", 0);
        }
        if (PlayerPrefs.GetInt("currentScore") > 0)
        {
            Text gameScore = gameScoreGO.GetComponent<Text>();
            int x = PlayerPrefs.GetInt("currentScore");
            gameScore.text = " BallHit : " + x;
        }
        Debug.Log("current score : " + PlayerPrefs.GetInt("currentScore"));
    }
}
