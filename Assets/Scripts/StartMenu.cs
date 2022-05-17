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
        if (g.name == "PlayButton")
        {
            FindObjectOfType<PlayerScript>().Run();
            StartCoroutine(DelaySceneLoad());
        }
        if (g.name == "SettingsButton")
        {
            FindObjectOfType<PlayerScript>().Dance(true);
            soundOn.gameObject.SetActive(true);
        }
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(1f); // Wait 1 seconds
        SceneManager.LoadScene("Race");
    }
}
