using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numberOfPlayersTextBehavior : MonoBehaviour {

    Text test;
	// Use this for initialization
	void Start () {
        test.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        //test.text = GameObject.Find("Slider").GetComponent<Slider>().value;
        
	}

    public void SetValue(float newValue)
    {
        test.text = newValue.ToString();
    }
}
