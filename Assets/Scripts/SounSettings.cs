using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SounSettings : MonoBehaviour
{
    private AudioManager audioManager;
    void Start()
    {
        audioManager = AudioManager.instance;
        audioManager.Play("Motor");
    }
    public void ToggleValueChanged(Toggle change)
    {
        FindObjectOfType<PlayerScript>().Dance(change.isOn);
        if (change.isOn)
        {
            //AudioListener.volume = 1;
            audioManager.Play("Motor");
        }
        else
        {
            audioManager.Stop("Motor");
            //AudioListener.volume = 0;
        }
        
    }
}
