using UnityEngine;

public class DecreaseScoreOnClick : MonoBehaviour
{
    public static DecreaseScoreOnClick decrease_instance;

    public void OnMouseDown()
    {
        GameObject gameObject3 = new GameObject();
        ScoreManager scoremanagerdec = gameObject3.AddComponent<ScoreManager>();

        scoremanagerdec.DecreaseScore(20);
        Debug.Log("Score Decreased by 20");
    }
}