using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnginePowerButton : MonoBehaviour,Interactable {


    public bool powered = false;

    public Teleport ladderTeleport;

    public Light Light;

    public Material coilMaterial;


    public bool pushedButton = false;

    public string HoverText()
    {
        if (powered == false)
        {
            if (pushedButton)
            {
                return "Powered Restored";
            }
            else{
                return "Power needs to be restored";
        }
        }else{
            return "Push Button";
        }
    }



    public void Interact(GameObject player)
    {
        if (powered == false)
        {

        }
        else
        {
            pushedButton = true;
            ladderTeleport.enabled = true;
            Light.enabled = true;


            float emission = Mathf.PingPong(Time.time, 1.0f);
            Color baseColor = Color.cyan; //Replace this with whatever you want for your base color at emission level '1'

            Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

            coilMaterial.SetColor("_EmissionColor", finalColor);
        }
    }



    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
