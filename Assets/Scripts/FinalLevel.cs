using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevel : MonoBehaviour
{
    public static FinalLevel finallevel_instance;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(4);
    }
}
