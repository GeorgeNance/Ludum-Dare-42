using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void Quit(){
        Application.Quit();
    }


    public void StartGame(){
        Cursor.lockState = CursorLockMode.Locked;
    }
}
