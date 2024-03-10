using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyCorpse : MonoBehaviour
{
    [SerializeField]
    Transform  ChildSprite;
    [SerializeField]
    int Score;
    int Combo = 0;
    [SerializeField]
    TextMeshPro textMesh;
    GameObject gameManagerObject;
    [SerializeField]
    AudioSource AudioSource;
    [SerializeField]
    AudioClip[] AudioClips;
    public void SetStartValues(int combo, Quaternion childSpriteAngle)
    {
        gameManagerObject = GameObject.FindGameObjectWithTag("Managers");
        int finalScore = combo * Score;
        gameManagerObject.GetComponent<ScoreManager>().Score += finalScore;
        ChildSprite.transform.rotation =childSpriteAngle;
        Combo = combo;
        textMesh.text = $"{finalScore}";
    }
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0,AudioClips.Length);
        AudioSource.PlayOneShot(AudioClips[randomIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
