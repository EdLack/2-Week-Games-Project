using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore");

        scoreText.text = "Final Score: " + finalScore.ToString();
    }
}
