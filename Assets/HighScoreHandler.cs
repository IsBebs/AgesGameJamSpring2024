using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HighScoreHandler : MonoBehaviour
{
    const string filename = "HighScoreDoNotTouch.txt";
    string filePath;
    [SerializeField]
    int StartHighScore;

    private void Awake()
    {
        filePath = Path.Combine(Application.dataPath, filename);
    }
    public void CreateFileIfNotExist()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.Write(StartHighScore);
            streamWriter.Close();
        }
    }
    // Start is called before the first frame update
    public int ReadHighScore()
    {
        CreateFileIfNotExist();
        StreamReader streamReader = new StreamReader(filePath);
        string scoreString = streamReader.ReadLine();
        streamReader.Close();
        int score = 0;
        if (int.TryParse(scoreString, out score))
        {
            return score;
        }
        else
        {
            return StartHighScore;
        }
    }

    // Update is called once per frame
    void WriteHighScore(int newScore)
    {
        StreamWriter streamWriter = new StreamWriter(filePath);
        streamWriter.Write(newScore);
        streamWriter.Close();
    }
}
