using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsButtons : MonoBehaviour
{
    public void click(GameObject g)
    {
        if (g.name == "Play")
        {
            SceneManager.LoadScene("Race");
        }
        if (g.name == "Menu")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
