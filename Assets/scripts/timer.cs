﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerLabel;

    public float time;

    void Update()
    {
        if (GameManager.gameStarted)
        {
            if (time > 0.0f)
            {
                time -= Time.deltaTime;

                var minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
                var seconds = time % 60;//Use the euclidean division for the seconds.
                //var fraction = (time * 100) % 100;

                //update the label value
                timerLabel.text = string.Format("{0:00} : {1:00}", minutes, seconds);
            }
            else
            {
                time = 0.0f;
            }

        }
    }

}