using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour {

	// Use this for initialization

	void Awake () {
        DontDestroyOnLoad(gameObject);
	}

    private void Start()
    {
        SceneManager.LoadScene(1);
    }
}
