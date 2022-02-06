using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonManager : MonoBehaviour
{

    public void StartNewGame()
    {
        SceneManager.LoadScene("main");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
