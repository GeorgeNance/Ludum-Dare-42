using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightPickup : MonoBehaviour,Interactable {
    
    public string HoverText()
    {
        return "Pick up Flashlight";
    }

    public void Interact(GameObject player)
    {
        PlayerAttributes.instance.flashLightEnabled = true;
        PlayerAttributes.instance.flashLight = true;
        PlayerAttributes.instance.flashLightObject.enabled = true;

        Inventory.Instance.Add(new CollectableObject() { name = "flashlight" });

        this.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
