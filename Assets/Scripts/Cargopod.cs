using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargopod : MonoBehaviour,Interactable {


    public GameObject WinScreen;

    public string HoverText()
    {
        return "Take Cargo pod";
    }

    public void Interact(GameObject player)
    {
        WinScreen.SetActive(true);
        player.GetComponent<CamerController>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
