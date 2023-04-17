using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour
{
    public void RestartButtonPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
