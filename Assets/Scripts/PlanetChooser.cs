using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetChooser : MonoBehaviour {

    [SerializeField]
    GameObject sceneBackgroundColor;
    [SerializeField]
    GameObject mainMenu;
    [SerializeField]
    GameObject gameScene;
    [SerializeField]
    GameObject ballGO;
    [SerializeField]
    GameObject gameScoreHide;

    float earthGravity = -9.8f;
    float moonGravity = -1.6f;
    float jupiterGravity = -24.5f;
    string planetName;
    Vector2 currentGravity;

    private void Start()
    {
        currentGravity = Physics2D.gravity;
        planetName = gameObject.name;
        Debug.Log(currentGravity + " " + planetName);
        gameScene.SetActive(false);
        ballGO.transform.position = new Vector3(-6f, 4, -3);
        mainMenu.SetActive(true);
        gameScoreHide.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            //if (Application.platform == RuntimePlatform.Android)
            //{
                ballGO.transform.position = new Vector3(-6f, 4, -3);
                gameScene.SetActive(false);
                mainMenu.SetActive(true);
                gameScoreHide.SetActive(true);
            //}
            //else
            //{
            //    BallGO.transform.position = new Vector3(-6f, 4, -3);
            //    GameScene.SetActive(false);
            //    MainMenu.SetActive(true);
            //}
        }
    }   
    public void EarthChoosen ()
    {
        sceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.56f, 0.77f, 1f, 1f);
        ballGO.GetComponent<Rigidbody2D>().gravityScale = 1f; // earth
        Debug.Log("earth choosen" + ballGO.GetComponent<Rigidbody2D>().gravityScale);
        gameScene.SetActive(true);
        mainMenu.SetActive(false);
        gameScoreHide.SetActive(false);

    }
    public void MoonChoosen()
    {
        sceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.79f, 0.79f, 0.79f, 1f);
        ballGO.GetComponent<Rigidbody2D>().gravityScale = 0.163f; //  1.6/9.81 = 0.163
        Debug.Log("moon choosen" + ballGO.GetComponent<Rigidbody2D>().gravityScale);
        gameScene.SetActive(true);
        mainMenu.SetActive(false);
        gameScoreHide.SetActive(false);
    }
    public void JupiterChoosen()
    {
        ballGO.GetComponent<Rigidbody2D>().gravityScale = 2.497f; // 24.5/9.8 = 2.497
        Debug.Log("jupiter choosen" + ballGO.GetComponent<Rigidbody2D>().gravityScale);
        sceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.72f, 0.25f, 1f, 1f);
        gameScene.SetActive(true);
        mainMenu.SetActive(false);
        gameScoreHide.SetActive(false);
    }
}
