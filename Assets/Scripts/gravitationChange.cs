using UnityEngine;

public class gravitationChange : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private playerMove _player;

    private bool _top;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _player = GetComponent<playerMove>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.gravityScale *= -1;
            Rotation();
        }
    }

    private void Rotation()
    {
        if (_top == false)
            transform.eulerAngles = new Vector3(0, 0, 180);
        else
            transform.eulerAngles = Vector3.zero;

        _player.faceRight = !_player.faceRight;
        _top = !_top;
    }

    public void GravityButtonPress()
    {
        _rigidbody.gravityScale *= -1;
        Rotation();
    }
}