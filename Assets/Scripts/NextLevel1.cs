using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{
    public static NextLevel1 nextlevel1_instance;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
