using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public void OnReturnButton()
    {
        ScoreManager.score_instance.score = 0;
        ScoreManager.score_instance.ResetScore();
        Debug.Log("Score Reset to 0");
        SceneManager.LoadScene(0);
    }
}
