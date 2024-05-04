using UnityEngine;

public class ResetScore : MonoBehaviour
{
    private void OnMouseDown()
    {
        ScoreManager.score_instance.score = 0;
        ScoreManager.score_instance.ResetScore();
        Debug.Log("Score Reset to 0");
    }
    public void ResetScoreFunction()
    {
        ScoreManager.score_instance.score = 0;
        ScoreManager.score_instance.ResetScore();
        Debug.Log("Score Reset to 0");
    }
}
