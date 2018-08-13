using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenManager : MonoBehaviour {

    private float timer = 0;

    public static OxygenManager Instance;
    private int maxTime = 90;

    public GameObject GameOverScreen;


	// Use this for initialization
	void Start () {
        GameOverScreen.SetActive(false);
        Instance = this;
        timer = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;


        if (timer <= 0){
            GameOver();
        }
	}


    public float GetOxyPercent(){
        return Mathf.Clamp01(timer / maxTime);
    }

    public void SetOxygenTime(int amount){
        maxTime = amount;
        timer = amount;
    }


    void GameOver(){
        GameOverScreen.SetActive(true);
        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<CamerController>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        Cursor.lockState = CursorLockMode.None;

    }

}
