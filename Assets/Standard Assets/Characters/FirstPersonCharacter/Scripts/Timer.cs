using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour
{

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Setting")]
    public float currentTime;

    public bool TimerEnabled = true;

    
 
    // Update is called once per frame
    void Update()
    {
        if(TimerEnabled == true)
        {
        currentTime = currentTime += Time.deltaTime;
        SetTimerText();
        }
    }

    private void SetTimerText()
        {
            timerText.text = currentTime.ToString("0.00");
        }
}
