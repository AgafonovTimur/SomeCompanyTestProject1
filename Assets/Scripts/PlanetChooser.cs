using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetChooser : MonoBehaviour {

    [SerializeField]
    GameObject SceneBackgroundColor;
    [SerializeField]
    GameObject MainMenu;
    [SerializeField]
    GameObject GameScene;
    [SerializeField]
    GameObject BallGO;

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
        GameScene.SetActive(false);
        BallGO.transform.position = new Vector3(-6f, 4, -3);
        MainMenu.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            //if (Application.platform == RuntimePlatform.Android)
            //{
                BallGO.transform.position = new Vector3(-6f, 4, -3);
                GameScene.SetActive(false);
                MainMenu.SetActive(true);
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
        SceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.56f, 0.77f, 1f, 1f);
        BallGO.GetComponent<Rigidbody2D>().gravityScale = 1f; // earth
        Debug.Log("earth choosen" + BallGO.GetComponent<Rigidbody2D>().gravityScale);
        GameScene.SetActive(true);
        MainMenu.SetActive(false);
        
    }
    public void MoonChoosen()
    {
        SceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.79f, 0.79f, 0.79f, 1f);
        BallGO.GetComponent<Rigidbody2D>().gravityScale = 0.163f; //  1.6/9.81 = 0.163
        Debug.Log("moon choosen" + BallGO.GetComponent<Rigidbody2D>().gravityScale);
        GameScene.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void JupiterChoosen()
    {
        BallGO.GetComponent<Rigidbody2D>().gravityScale = 2.497f; // 24.5/9.8 = 2.497
        Debug.Log("jupiter choosen" + BallGO.GetComponent<Rigidbody2D>().gravityScale);
        SceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.72f, 0.25f, 1f, 1f);
        GameScene.SetActive(true);
        MainMenu.SetActive(false);
    }
}
