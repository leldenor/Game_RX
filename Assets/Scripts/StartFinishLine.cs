using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFinishLine : MonoBehaviour
{
    private int laps = 0;
    public int maxLaps;

    public Text text;
    private void OnTriggerEnter(Collider other)
    {
        if (laps == 0)
        {
            FindObjectOfType<Timer>().StartTimer();
        }
        else if (laps == maxLaps)
        {
            FindObjectOfType<Timer>().StopTimer();
        }

        FindObjectOfType<LapCount>().DisplayLaps(laps);
        laps++;
    }
}
