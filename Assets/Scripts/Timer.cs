using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float initialTimer;
    public Text timerText;

    void Start()
    {
        currentTime = initialTimer;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 1f)
        {
            SceneManager.LoadScene("GameOver");
        }

        timerText.text = FormatTime(currentTime);
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
