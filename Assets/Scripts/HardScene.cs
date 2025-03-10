using UnityEngine;
using UnityEngine.SceneManagement;

public class HardScene : MonoBehaviour
{
    public float initialTimer = 270f;

    public void LoadMainScene()
    {
        Timer timerScript = FindObjectOfType<Timer>();
        if (timerScript != null)
        {
            timerScript.initialTimer = initialTimer;
        }

        SceneManager.LoadScene("HardScene");
    }
}

