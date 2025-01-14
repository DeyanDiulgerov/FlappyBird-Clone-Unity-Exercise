using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class HighScore
{
    public string playerName;
    public int score;
    public string date;
}

public class HighScoreManager
{
    private const int MAX_SCORES = 20;
    private List<HighScore> highScores = new List<HighScore>();

    public void AddScore(string name, int score)
    {
        HighScore newScore = new HighScore
        {
            playerName = name,
            score = score,
            date = System.DateTime.Now.ToString()
        };

        highScores.Add(newScore);
        highScores = highScores.OrderByDescending(x => x.score).Take(MAX_SCORES).ToList();
        SaveScores();
    }

    void SaveScores()
    {
        string json = JsonUtility.ToJson(new { scores = highScores });
        PlayerPrefs.SetString("highScores", json);
        PlayerPrefs.Save();
    }

    void LoadScores()
    {
        string json = PlayerPrefs.GetString("highScores", "");
        Console.WriteLine(String.Join(",", highScores.OrderByDescending(x => x.score).Take(MAX_SCORES).ToList()));
    }
}