using UnityEngine;

public class IncreaseScoreOnClick : MonoBehaviour
{
    public static IncreaseScoreOnClick increase_instance;

    public void OnMouseDown()
    {
        GameObject gameObject2 = new GameObject();
        ScoreManager scoremanagerinc = gameObject2.AddComponent<ScoreManager>();

        scoremanagerinc.IncreaseScore(50);
        Debug.Log("Score increased by 50");
    }
}