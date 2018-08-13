using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        string list = "<b>Items</b>:\n";
        foreach(CollectableObject c in Inventory.Instance.collectables){
            list = list + " - "+c.name + "\n";
        }

        text.text = list;
	}
}
