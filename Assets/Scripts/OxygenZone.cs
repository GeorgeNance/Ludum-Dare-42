﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenZone : MonoBehaviour {

    public int time;

    private bool toggled;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!toggled)
            {
                OxygenManager.Instance.SetOxygenTime(time);
                toggled = true;
            }
        }
    }
}
