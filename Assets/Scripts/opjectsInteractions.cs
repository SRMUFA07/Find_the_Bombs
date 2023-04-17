using UnityEngine;

public class opjectsInteractions : MonoBehaviour {

	private Rigidbody2D _rigidbody;
	private playerMove _player; 

	private float jumpPower = 6;

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		_player = GetComponent<playerMove>();
	}

	private void OnCollisionEnter2D(Collision2D collision) 
	{
		if(collision.gameObject.tag == "jumpPad")
			_rigidbody.velocity = Vector2.up * jumpPower;
	}
}