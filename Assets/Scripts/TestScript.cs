using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

//using static NextLevel1;

[TestFixture]
public class TestScript
{

    [UnityTest]
    public IEnumerator NextLevel1_OnMouseDown_LoadsNextScene()
    {
        GameObject gameObject = new GameObject();
        NextLevel1 nextLevel1 = gameObject.AddComponent<NextLevel1>();

        nextLevel1.OnMouseDown();

        Assert.AreEqual(4, SceneManager.GetActiveScene().buildIndex);

        yield return null;
    }

    [UnityTest]
    public IEnumerator NextLevel2_OnMouseDown_LoadsNextScene()
    {
        GameObject gameObject = new GameObject();
        NextLevel2 nextLevel2 = gameObject.AddComponent<NextLevel2>();

        nextLevel2.OnMouseDown();

        Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);

        yield return null;
    }

    [UnityTest]
    public IEnumerator FinalLevel_OnMouseDown_LoadsNextScene()
    {
        GameObject gameObject = new GameObject();
        FinalLevel finalLevel = gameObject.AddComponent<FinalLevel>();

        finalLevel.OnMouseDown();

        Assert.AreEqual(5, SceneManager.GetActiveScene().buildIndex);

        yield return null;
    }




    /**[UnityTest]
    public IEnumerator IncreaseScoreOnClick_Adds50Score()
    {
        GameObject gameObject = new GameObject();
        IncreaseScoreOnClick increaseScoreOnClick = gameObject.AddComponent<IncreaseScoreOnClick>();
        //ScoreManager scoreManager = new ScoreManager();

        increaseScoreOnClick.OnMouseDown();

        Assert.AreEqual(50, ScoreManager.score_instance.score, "Score was not increased by 50 as expected");

        yield return null;
    }
    **/

    [UnityTest]
    public IEnumerator DecreaseScoreOnClick_Subtracts20Score()
    {
        GameObject gameObject = new GameObject();
        DecreaseScoreOnClick decreaseScoreOnClick = gameObject.AddComponent<DecreaseScoreOnClick>();
        //ScoreManager scoreManager = new ScoreManager();

        decreaseScoreOnClick.OnMouseDown();

        Assert.AreEqual(-20, ScoreManager.score_instance.score, "Score was not decreased by 20 as expected");

        yield return null;
    }
}

