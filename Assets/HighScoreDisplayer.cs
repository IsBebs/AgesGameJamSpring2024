using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreDisplayer : MonoBehaviour
{
    [SerializeField]
    HighScoreHandler ScoreHandler;
    [SerializeField]
    TextMeshProUGUI HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        int score = ScoreHandler.ReadHighScore();
        HighScoreText.text = $"HighScore:{score}";
    }

}
