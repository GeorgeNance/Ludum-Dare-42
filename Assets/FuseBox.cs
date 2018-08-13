using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseBox : MonoBehaviour,Interactable {


    public GameObject fuse1;
    public GameObject fuse2;


    public EnginePowerButton button;

    public string HoverText()
    {
        if (!fuse1.active && !fuse2.active)
        {
            if (Inventory.Instance.Check("fuse1"))
            {
                return "Insert Fuse";
            }
            else if (Inventory.Instance.Check("fuse2"))
            {
                return "Insert Fuse";
            }
            else
            {
                return "The box is missing some fuses";

            }
        }else{
            return "All Fuses Found. Start the power";
        }

    }

    public void Interact(GameObject player)
    {
        if (!fuse1.active && !fuse2.active)
        {
            if (Inventory.Instance.Check("fuse1"))
            {
                Inventory.Instance.Remove("fuse1");
                fuse1.SetActive(true);
                fuse1.GetComponent<Animator>().SetTrigger("insert");
            }
            if (Inventory.Instance.Check("fuse2"))
            {
                Inventory.Instance.Remove("fuse2");
                fuse2.SetActive(true);
                fuse2.GetComponent<Animator>().SetTrigger("insert");
            }
            else
            {
                

            }
        }
        else
        {
            button.powered = true;
        }


    }

    // Use this for initialization
	void Start () {
        fuse1.SetActive(false);
        fuse2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
