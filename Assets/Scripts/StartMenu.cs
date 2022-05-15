using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Toggle soundOn;

    void Start()
    {
        soundOn.gameObject.SetActive(false);
    }
    public void click(GameObject g)
    {
        print(g.name);
        if (g.name == "PlayButton")
        {
            SceneManager.LoadScene("Race");
        }
        if (g.name == "SettingsButton")
        {
            soundOn.gameObject.SetActive(true);
        }
    }
}
