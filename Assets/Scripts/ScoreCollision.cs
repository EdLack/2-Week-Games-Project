using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCollision : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("FinalScore", score);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Coin")  
        {
            Destroy(col.gameObject); 

            score++; 

            UpdateScoreUI(); 
        }
        if (col.gameObject.name == "Coin(1)")  
        {
            Destroy(col.gameObject); 

            score++; 

            UpdateScoreUI(); 
        }
        if (col.gameObject.name == "Coin(2)")  
        {
            Destroy(col.gameObject); 

            score++; 

            UpdateScoreUI(); 
        }
        if (col.gameObject.name == "Coin(3)") 
        {
            Destroy(col.gameObject); 

            score++; 

            UpdateScoreUI(); 
        }
        if (col.gameObject.name == "Coin(4)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(5)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(6)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(7)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(8)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(9)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(10)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
        if (col.gameObject.name == "Coin(11)")
        {
            Destroy(col.gameObject);

            score++;

            UpdateScoreUI();
        }
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("FinalScore", score);

        if (score == 12f)
        {
            SceneManager.LoadScene("Winner");

        }
    }
}
