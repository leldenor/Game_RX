using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public ScoreManager scoreManager;
    public RowUi rowUi;
    // Start is called before the first frame update
    void Start()
    {
        var scores = scoreManager.GetScores().ToArray();
        foreach (var item in scores)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            float minutes = Mathf.FloorToInt(item / 60);
            float seconds = Mathf.FloorToInt(item % 60);

            row.scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

}
