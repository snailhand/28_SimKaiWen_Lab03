using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void WinScene()
    {
        SceneManager.LoadScene("GameWinScene");
    }

    public void LoseScene()
    {
        SceneManager.LoadScene("GameLoseScene");
    }
}
