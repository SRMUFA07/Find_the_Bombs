using UnityEngine;
using UnityEngine.UI;

public class volumeControl : MonoBehaviour {

	public Sprite volumeOn;
	public Sprite volumeOff;
	public GameObject volumeButton;

	public void VolumeOffOn() {
		if(AudioListener.volume == 1)
		{
			AudioListener.volume = 0;
			volumeButton.GetComponent<Image>().sprite = volumeOff;
		}
		else
		{
			AudioListener.volume = 1;
			volumeButton.GetComponent<Image>().sprite = volumeOn;
		}
	}
}
