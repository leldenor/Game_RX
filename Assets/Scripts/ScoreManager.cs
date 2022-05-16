using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class MyList
{
    public List<float> list = new List<float>();
}
public class ScoreManager : MonoBehaviour
{
    private MyList scores;

    // Start is called before the first frame update
    void Awake()
    {
        var json = PlayerPrefs.GetString("Scores", "[]");
        scores = JsonUtility.FromJson<MyList>(json);
        var time = PlayerPrefs.GetFloat("Time", 0);
        print(time);
        AddScore(time);
    }

    public IEnumerable<float> GetScores()
    {
        return scores.list.OrderBy(x => x);
    }

    public void AddScore(float score)
    {
        scores.list.Add(score);
    }

    private void OnDestroy()
    {
        SaveScores();
    }
    public void SaveScores()
    {
        var json = JsonUtility.ToJson(scores);
        PlayerPrefs.SetString("Scores", json);
    }
}
