using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class bombSelect : MonoBehaviour 
{
	public GameObject levelCompletePanel;

	public Text bombValueCanvas;
	public float bombValue;

    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private void Start () =>
		bombValueCanvas.text = bombValue.ToString();
	
	private void Update () 
	{
		if(bombValue == 10)
		{
			ShowAdv();
			levelCompletePanel.SetActive(true);
			Time.timeScale = 0;
		}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(collision.gameObject);
            bombValue = bombValue + 1;
            bombValueCanvas.text = bombValue.ToString();
        }
    }
}