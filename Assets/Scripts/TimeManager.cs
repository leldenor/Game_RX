using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int maxLaps;

    public Text lapsText;
    public Text timerText;
    public Text timeScore;
    public Text exitText;

    private bool isStarted = false;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        lapsText.text = string.Format("{0}/{1}", 0, maxLaps);
        timeScore.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        {
            exitText.gameObject.SetActive(false);
            time += Time.deltaTime;
            timerText.text = time.ToString("0.00");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        DisplayTime(time);
    }

    public void StartFinish(int currentLap)
    {
        if (currentLap == 0)
        {
            StartTimer();
        }
        else if (currentLap == maxLaps)
        {
            
            StopTimer();
        }
        lapsText.text = string.Format("{0}/{1}", currentLap, maxLaps);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        isStarted = true;
    }

    public void StopTimer()
    {
        isStarted = false;
        timerText.gameObject.SetActive(false);
        timeScore.text = timerText.text;
        timeScore.gameObject.SetActive(true);
        SaveScore(time);
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(5f); // Wait 5 seconds
        SceneManager.LoadScene("Results");
    }

    public void SaveScore(float time)
    {
        PlayerPrefs.SetFloat("Time", time);
    }
}
