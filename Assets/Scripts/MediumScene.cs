using UnityEngine;
using UnityEngine.SceneManagement;

public class MediumScene : MonoBehaviour
{
    public float initialTimer = 360f;

    public void LoadMainScene()
    {
        Timer timerScript = FindObjectOfType<Timer>();
        if (timerScript != null)
        {
            timerScript.initialTimer = initialTimer;
        }

        SceneManager.LoadScene("MediumScene");
    }
}

