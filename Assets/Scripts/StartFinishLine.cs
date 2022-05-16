using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishLine : MonoBehaviour
{
    private int laps = 0;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<TimeManager>().StartFinish(laps);
        laps++;
    }
}
