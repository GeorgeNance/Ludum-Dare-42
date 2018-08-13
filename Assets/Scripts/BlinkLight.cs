using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class BlinkLight : MonoBehaviour {

    public int rate;

    private float timer;
    private Light light;

    private float lightIntensity;

    private bool fadeUp = true;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        lightIntensity = light.intensity;
	}
	
	// Update is called once per frame
	void Update () {
        if (fadeUp)
        {
            timer += Time.deltaTime;

            light.intensity = (1 / rate) * lightIntensity;
            if (timer >= 1 / rate)
            {
                fadeUp = false;
            }

        }else{
            timer -= Time.deltaTime;

            light.intensity = (1 / rate) * lightIntensity;
            if (timer <= 0)
            {
                fadeUp = true;
            }
        }


	}


    void Blink(){
        
    }
}
