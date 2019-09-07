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
        currentGravity = new Vector2(0, earthGravity);
        Debug.Log("earth choosen" + currentGravity);
        SceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.56f, 0.77f, 1f, 1f);
  //      BallGO.GetComponent<BaskeballMovement>().setBallGravity(earthGravity);
        GameScene.SetActive(true);
        MainMenu.SetActive(false);
        
    }
    public void MoonChoosen()
    {
        currentGravity = new Vector2(0, moonGravity);
        Debug.Log("moon choosen" + currentGravity);
        SceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.79f, 0.79f, 0.79f, 1f);
        GameScene.SetActive(true);
        MainMenu.SetActive(false);
 //       BallGO.GetComponent<BaskeballMovement>().setBallGravity(moonGravity);
    }
    public void JupiterChoosen()
    {
        currentGravity = new Vector2(0, jupiterGravity);
        Debug.Log("jupiter choosen" + currentGravity);
        SceneBackgroundColor.GetComponent<SpriteRenderer>().color = new Color(0.72f, 0.25f, 1f, 1f);
        GameScene.SetActive(true);
        MainMenu.SetActive(false);
   //     BallGO.GetComponent<BaskeballMovement>().setBallGravity(jupiterGravity);
    }
    // gravity = vector2.y , направление не равно гравитации
}
