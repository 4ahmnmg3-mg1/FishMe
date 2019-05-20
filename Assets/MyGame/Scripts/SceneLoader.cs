using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static string MAINSCENE = "MainScene";
    public static string GAMEOVER = "GameOver";

    public ScoreData scoreData;

    public void LoadMainScene()
    {
        SceneManager.LoadScene(MAINSCENE);
        ResetPoints();
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(GAMEOVER);
    }

    private void ResetPoints()
    {
        scoreData.points = 0;
    }
}
