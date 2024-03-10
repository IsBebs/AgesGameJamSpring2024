using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CanvasHandler : MonoBehaviour
{
    [SerializeField]
    GameObject playerObject;
    [SerializeField]
    GameObject GameUI;
    [SerializeField]
    GameObject GameOverUI;
    [SerializeField]
    TextMeshProUGUI GameOverText;
    [SerializeField]
    ScoreManager ScoreManager;
    bool DoneUpdating = false;
    [SerializeField]
    HighScoreHandler ScoreHandler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (DoneUpdating)
            return;
        if (playerObject.activeInHierarchy)
        {
            GameUI.SetActive(true);
            GameOverUI.SetActive(false);
        }
        else
        {
            GameUI.SetActive(false);
            GameOverUI.SetActive(true);
            int highScore = ScoreHandler.ReadHighScore();
            if (highScore >= ScoreManager.Score)
            {
                GameOverText.text = $"Game over {Environment.NewLine}Your score was {ScoreManager.Score}{Environment.NewLine}HighScore is {highScore}";
            }
            else
            {
                ScoreHandler.WriteHighScore(ScoreManager.Score);
                GameOverText.text = $"Congratulations!{Environment.NewLine}You have beaten the highscore{Environment.NewLine}Your Final Score is {ScoreManager.Score}";
            }
         
           
            DoneUpdating = true;
        }
    }
}
