using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private void Update()
    {
        GameObject gameObject1 = new GameObject();
        ScoreManager scoremanager = gameObject.AddComponent<ScoreManager>();

        if (ScoreManager.score_instance != null)
        {
            scoreText.text = "Score: " + scoremanager.score.ToString();
            highScoreText.text = "High Score: " + ScoreManager.score_instance.highScore.ToString();
        }
        else
        {
            Debug.LogWarning("Score instance is null!");
        }
    }
}
