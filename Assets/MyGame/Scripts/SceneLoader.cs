using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static string MAINSCENE = "MainScene";
    public static string GAMEOVER = "GameOverScene";

    public void LoadMainScene()
    {
        SceneManager.LoadScene(MAINSCENE);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(GAMEOVER);
    }
}
