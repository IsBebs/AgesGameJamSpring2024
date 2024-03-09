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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (playerObject.activeInHierarchy)
        {
            GameUI.SetActive(true);
            GameOverUI.SetActive(false);
        }
        else
        {
            GameUI.SetActive(false);
            GameOverUI.SetActive(true);
            GameOverText.text = $"Game over {Environment.NewLine}Your score was {ScoreManager.Score}{Environment.NewLine}";
        }
    }
}
