using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkKeyPad : MonoBehaviour, Interactable {

    public Animator DoorAnim;
    public Material keypadMaterial;
    public string itemName = "badge";



    public string HoverText()
    {
        if (Inventory.Instance.Check(itemName))
        {
            return "Swipe badge";
        }else{
            return "You need a " + itemName;
        }
    }

    public void Interact(GameObject player)
    {

        if (Inventory.Instance.Check(itemName)){

            keypadMaterial.SetColor("_EmissionColor", Color.green);
            keypadMaterial.EnableKeyword("_EMISSION");
  
            DoorAnim.SetTrigger("Open");

        }else{
            keypadMaterial.SetColor("_EmissionColor", Color.red);
            keypadMaterial.EnableKeyword("_EMISSION");
        }
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
