using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    public int startTime = 120;
    public Text clockText;
    private int timeRemaining;
    static public bool TimesUp { get; set; }

    // Use this for initialization
    void Start()
    {
        TimesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining = startTime - (int)Time.time;
        if (timeRemaining <= 0 || TimesUp == true)
        {
            TimesUp = true;
            clockText.text = "Time Left = 0:00";
        }
        else
        {
            int minutes = timeRemaining / 60;
            int seconds = timeRemaining % 60;
            clockText.text = "Time Left = " + minutes + ":" + seconds.ToString("D2");
        }
    }
}
