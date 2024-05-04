using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager score_instance;

    public int score = 0;
    public int highScore = 0;

    private string highScoreFilePath;

    private void Awake()
    {
        if (score_instance == null)
        {
            score_instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        highScoreFilePath = Application.persistentDataPath + "/highscore.txt";
        Debug.Log(Application.persistentDataPath);
        LoadHighScore();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        if (score > highScore)
        {
            highScore = score;
            SaveHighScore();
        }
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
    }

    public void ResetScore()
    {
        score = 0;
    }

    private void LoadHighScore()
    {
        if (File.Exists(highScoreFilePath))
        {
            highScore = int.Parse(File.ReadAllText(highScoreFilePath));
        }
    }

    private void SaveHighScore()
    {
        File.WriteAllText(highScoreFilePath, highScore.ToString());
    }

}
