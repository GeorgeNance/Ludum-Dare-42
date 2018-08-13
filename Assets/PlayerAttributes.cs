using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour {

    public static PlayerAttributes instance;

    public bool flashLight = false;
    public bool flashLightEnabled = false;
    public Light flashLightObject;


	// Use this for initializatio n
	void Start () {
        instance = this;
        flashLightObject.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		

        if (Input.GetKeyDown(KeyCode.L)){
            TurnFlashLightOn();
        }
	}

    public void TurnFlashLightOn(){
        if (Inventory.Instance.Check("flashlight")){
            flashLightObject.enabled = !flashLightObject.enabled;
        }
    }
}
