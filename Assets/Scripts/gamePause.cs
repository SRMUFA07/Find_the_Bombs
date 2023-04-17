using UnityEngine;
using UnityEngine.UI;

public class gamePause : MonoBehaviour
{

    public GameObject pausePanel;

    public void pauseButtonDown()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
