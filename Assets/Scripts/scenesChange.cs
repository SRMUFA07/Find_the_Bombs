using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesChange : MonoBehaviour
{

    public GameObject loadScreen;

    public void ChangeScenes(int numberScenes)
    {
        loadScreen.SetActive(true);

        SceneManager.LoadScene(numberScenes);
        Time.timeScale = 1;
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
