using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour,Interactable {


    private Animator animator;

    public string HoverText()
    {
        if (animator.GetBool("isOpen")){
            return "Close";
        }else{
            return "Open";
        }

    }

    public void Interact(GameObject player)
    {
        animator.SetBool("isOpen", !animator.GetBool("isOpen"));
    }

    // Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}




}
