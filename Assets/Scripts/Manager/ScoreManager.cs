using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int score=0;
    [SerializeField]
    GameObject playerObject;
    [SerializeField]
    int TimeScore =10;
    [SerializeField]
    float ScoreInterVal = 1;
    float ScoreTimer;

    [SerializeField]
    TextMeshProUGUI ScoreText;


    private void Start()
    {
        ScoreTimer = ScoreInterVal;
        Score = 0;
    }
    public int Score { 
        get { return score; }
        set 
        {
            if (playerObject != null && playerObject.activeInHierarchy)
            {
                score = value;
                ScoreText.text = $"Score:{score}";
            }
         
        } 
    }


    private void FixedUpdate()
    {
        if (playerObject != null && playerObject.activeInHierarchy)
        {
            ScoreTimer -= Time.fixedDeltaTime;
            if (ScoreTimer < 0)
            {
                Score += TimeScore;
                ScoreTimer = ScoreInterVal;
            }
        }

    }

    // Start is called before the first frame update

}
