using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesCollision : MonoBehaviour
{
    public Text livesText;
    public static int lives = 3;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FLOWER")
        {
            Destroy(col.gameObject);

            lives--;

            UpdateLivesUI();
        }
        if (col.gameObject.name == "FLOWER (1)")
        {
            Destroy(col.gameObject);

            lives--;

            UpdateLivesUI();
        }
        if (col.gameObject.name == "FLOWER (2)")
        {
            Destroy(col.gameObject);

            lives--;

            UpdateLivesUI();
        }
        if (col.gameObject.name == "FLOWER (3)")
        {
            Destroy(col.gameObject);

            lives--;

            UpdateLivesUI();
        }
    }

    private void UpdateLivesUI()
    {
        livesText.text = "Lives: " + lives.ToString();
        if (lives <= 0f)
        {
            SceneManager.LoadScene("GameOver");
 
        }
    }
}