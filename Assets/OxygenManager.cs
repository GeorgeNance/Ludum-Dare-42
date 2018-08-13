using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenManager : MonoBehaviour {

    private float timer = 0;

    public static OxygenManager Instance;
    private int maxTime = 90; 

	// Use this for initialization
	void Start () {
        Instance = this;
        timer = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
	}


    public float GetOxyPercent(){
        return Mathf.Clamp01(timer / maxTime);
    }

    public void SetOxygenTime(int amount){
        maxTime = amount;
        timer = amount;
    }
}
