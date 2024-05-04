using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    public static NextLevel2 nextlevel2_instance;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }
}
