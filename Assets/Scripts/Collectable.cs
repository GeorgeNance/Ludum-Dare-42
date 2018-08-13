using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour, Interactable
{

    public CollectableObject collectableObj;

    public string hoverText = "Collect Item";

    public string HoverText()
    {
        return collectableObj.hoverText;
    }

    public void Interact(GameObject player)
    {
        Inventory.Instance.Add(collectableObj);
        this.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
