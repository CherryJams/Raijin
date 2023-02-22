using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private bool timerIsRunning = false;

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
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f0");
            string milliseconds = ((t * 1000) % 1000).ToString("f0");
            Debug.Log(minutes + ":" + seconds + ":" + milliseconds);
        }
    }
}