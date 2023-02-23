using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float startTime;
    private bool timerIsRunning = false;
    private String minutes;
    private String seconds;
    private String milliseconds;

    void Start()
    {
        startTime = Time.time;
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            float t = Time.time - startTime;
            minutes = ((int) t / 60).ToString("00");
            seconds = (t % 60).ToString("00");
            milliseconds = ((t * 1000) % 1000).ToString("000").Substring(0, 2);
        }
    }

    public String GetTime()
    {
        return $"{minutes}:{seconds}:{milliseconds}";
    }
}