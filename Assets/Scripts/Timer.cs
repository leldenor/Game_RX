using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time = 0;
    public Text text;
    public Text timeScore;
    private bool isStarted = false;

    void Start()
    {
        timeScore.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        {
            time += Time.deltaTime;
            text.text = time.ToString("0.00");
        }

        DisplayTime(time);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        isStarted = true;
    }

    public void StopTimer()
    {
        isStarted = false;
        text.gameObject.SetActive(false);
        timeScore.text = text.text;
        timeScore.gameObject.SetActive(true);
    }
}
