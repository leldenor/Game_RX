using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SounSettings : MonoBehaviour
{

    public void ToggleValueChanged(Toggle change)
    {
        print(change.isOn);
        if (change.isOn)
        {
            //AudioListener.volume = 1;
            GameObject.FindObjectOfType<AudioManager>().Play("Motor");
        }
        else
        {
            GameObject.FindObjectOfType<AudioManager>().Stop("Motor");
            //AudioListener.volume = 0;
        }
        
    }
}
