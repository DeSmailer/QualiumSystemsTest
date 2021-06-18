using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timerText;

    private TimeSpan timePassed;
    private string minutes;
    private string seconds;
    private string milliseconds;

    private bool isRunning = false;

    private void Start()
    {
        timerText = GetComponent<TMP_Text>();
        timePassed = new TimeSpan();
    }

    private void Update()
    {
        if (isRunning == true)
        {
            timePassed = timePassed.Add(TimeSpan.FromSeconds(Time.deltaTime));

            minutes = timePassed.Minutes.ToString("00");
            seconds = timePassed.Seconds.ToString("00");
            milliseconds = timePassed.Milliseconds.ToString("00").Substring(0, 2);

            timerText.text = "<mspace=0.6em>" + minutes + ":" + seconds + ":" + milliseconds + "</mspace>";
        }
    }

    public void Restart()
    {
        timePassed = new TimeSpan();
        timerText.text = "<mspace=0.6em>00:00:00</mspace>";
        Run();
    }

    public void Run()
    {
        isRunning = true;
    }
}
