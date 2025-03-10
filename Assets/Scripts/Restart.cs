using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void LoadStartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }
}

