using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour,Interactable {

    public Transform destination;

    public string hoverText = "Use";

    public string HoverText()
    {
        return hoverText;
    }

    public void Interact(GameObject player)
    {
        player.transform.position = destination.position;
    }

    // Use this for initializationp
	void Start () {
        if (destination == null){
            destination = GetComponentInChildren<Transform>();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
