using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCount : MonoBehaviour
{
    public int maxLaps;

    public Text text;

    private void Start()
    {
        text.text = string.Format("{0}/{1}", 0, maxLaps);
    }
    public void DisplayLaps(int laps)
    {

        text.text = string.Format("{0}/{1}", laps, maxLaps);
    }
}
