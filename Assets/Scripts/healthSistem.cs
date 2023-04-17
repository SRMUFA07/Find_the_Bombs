using UnityEngine;
using UnityEngine.UI;

public class healthSistem : MonoBehaviour 
{
	[SerializeField] private AudioSource damageSound;

	public GameObject gameOverPanel;

	private Rigidbody2D _rigidbody;
	private playerMove _player;

	public float health;

	public Text hpValueCanvas;

	public float sawsDamage;
	public float spikesDamage;
	public float dieZonesDamage;
	public float mushroomDamage;
	public float batDamage;
	public float popoDamage;

	private void Start() 
	{
		hpValueCanvas.text = health.ToString();

		_rigidbody = GetComponent<Rigidbody2D>();
		_player = GetComponent<playerMove>();
	}

	private void Update() 
	{
		if(health <= 0) 
		{
			Time.timeScale = 0;
			gameOverPanel.SetActive(true);
		}
	}
	
	private void OnCollisionEnter2D(Collision2D collision) 
	{
		if(collision.gameObject.tag == "Saws") 
		{	
			damageSound.Play();
			health = health - sawsDamage;
			hpValueCanvas.text = health.ToString();
		}

		if(collision.gameObject.tag == "Spikes") 
		{
			damageSound.Play();
			health = health - spikesDamage;
			hpValueCanvas.text = health.ToString();
		}

		if(collision.gameObject.tag == "dieZones") 
		{
			damageSound.Play();
			health = health - dieZonesDamage;
			hpValueCanvas.text = health.ToString();
		}

		if(collision.gameObject.tag == "mushroomEnemy") 
		{
			damageSound.Play();
			_rigidbody.velocity = Vector2.up * 4;
			health = health - mushroomDamage;
			hpValueCanvas.text = health.ToString();
		}

		if(collision.gameObject.tag == "batEnemy") 
		{
			damageSound.Play();
			health = health - batDamage;
			hpValueCanvas.text = health.ToString();
		}

		if(collision.gameObject.tag == "popoEnemy") 
		{
			damageSound.Play();
			health = health - popoDamage;
			hpValueCanvas.text = health.ToString();
		}
	}
}
