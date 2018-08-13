using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour,Interactable {
    public string HoverText()
    {
        return "Test";
    }

    public void Interact(GameObject player)
    {
        Debug.Log("It worked!");
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
