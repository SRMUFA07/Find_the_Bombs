using UnityEngine;

public class areaPatrol : MonoBehaviour {

	public float enemySpeed;

	public Transform[] moveSpots;
	private int _randomSpot;

	private void Start () 
	{
		_randomSpot = Random.Range(0, moveSpots.Length);
	}

	private void Update () 
	{
		transform.position = Vector3.MoveTowards(transform.position, moveSpots[_randomSpot].position, enemySpeed * Time.deltaTime);

		if (Vector2.Distance(transform.position, moveSpots[_randomSpot].position) < 0.2)
			_randomSpot = Random.Range(0, moveSpots.Length);
	}

	private void OnCollisionEnter2D(Collision2D collision) 
	{
		if(collision.gameObject.tag == "Saws")
			Destroy(gameObject);

		if(collision.gameObject.tag == "Spikes")
			Destroy(gameObject);

		if(collision.gameObject.tag == "dieZones")
			Destroy(gameObject);
	}
}