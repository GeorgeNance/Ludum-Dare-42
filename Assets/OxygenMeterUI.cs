using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OxygenMeterUI : MonoBehaviour {


    public Image meter;

    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        UpdateMeter(OxygenManager.Instance.GetOxyPercent());
	}

    void UpdateMeter(float percent){
        meter.rectTransform.localScale = new Vector3(1, percent, 1);

        meter.color = Color.Lerp(Color.green, Color.red, 1-percent);


        text.text = string.Format("Room Oxygen:\n<b>{0}%</b>", Mathf.Round(percent* 100));
        if (percent <= 0.25f){
            text.color = Color.red;
        }else{
            text.color = Color.white;
        }
    }



}
