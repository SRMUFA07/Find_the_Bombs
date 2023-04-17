using UnityEngine;
using UnityEngine.UI;

public class gameContinue : MonoBehaviour {

	public GameObject pausePanel;

	public void continueButtonDown() {
		pausePanel.SetActive(false);
		Time.timeScale = 1;
	}
}
