using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyScene : MonoBehaviour
{
    public float initialTimer = 450f;

    public void LoadMainScene()
    {
        Timer timerScript = FindObjectOfType<Timer>(); 
        if (timerScript != null)
        {
            timerScript.initialTimer = initialTimer; 
        }

        SceneManager.LoadScene("EasyScene");
    }
}

