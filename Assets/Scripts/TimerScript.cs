using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float totalTime;

    private float timer;


    void Start()
    {
        timer = totalTime;
    }


    void Update()
    {
        if(timer >= 0)
        {
            timer -= Time.deltaTime * 1;
            timerText.text = "Timer: " + timer;
        }
        else
        {
            FindObjectOfType<SceneHandler>().WinScene();
        }
    }
}
