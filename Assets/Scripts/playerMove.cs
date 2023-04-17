using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    public Joystick joystick;

    public float moveInput;
    public float moveSpeed;

    public float jumpForce;

    public bool faceRight;

    public bool onGround;
    public Transform checkGround;
    public float checkRadius = 0.08f;
    public LayerMask Ground;

    public GameObject gravityButton;
    public GameObject jumpButton;
    public GameObject tutorialA;
    public GameObject tutorialD;
    public GameObject tutorialB;
    public GameObject tutorialSpace;

    private void Start()
    {
        Time.timeScale = 1;

        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        PlatformCheck();

        Run();

        Jump();

        CheckingGround();

        if (faceRight == false && moveInput > 0)
            Turn();
        else if (faceRight == true && moveInput < 0)
            Turn();


        if (moveInput == 0)
            _animator.SetBool("isRunning", false);
        else
            _animator.SetBool("isRunning", true);


        if (onGround == true)
            _animator.SetBool("isJumping", false);
        else
            _animator.SetBool("isJumping", true);
    }

    private void Run()
    {
        if (/*YandexSDK.Instance.CurrentDeviceType == Assets.Yandex.DeviceTypeEnum.Desktop*/ ChoosePlatform.pcDevise == true)
            moveInput = Input.GetAxis("Horizontal");
        else if (/*YandexSDK.Instance.CurrentDeviceType == Assets.Yandex.DeviceTypeEnum.Mobile*/ ChoosePlatform.pcDevise == false)
            moveInput = joystick.Horizontal;

        _rigidbody.velocity = new Vector2(moveInput * moveSpeed, _rigidbody.velocity.y);
    }


    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.B) && onGround)
            _rigidbody.velocity = Vector2.up * jumpForce;
    }

    private void Turn()
    {
        faceRight = !faceRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }

    public void CheckingGround() =>
        onGround = Physics2D.OverlapCircle(checkGround.position, checkRadius, Ground);


    public void JumpButtonPress()
    {
        if (onGround == true)
            _rigidbody.velocity = Vector2.up * jumpForce;
    }

    public void MoveButtonsUp()
    {
        moveSpeed = 0;
        _animator.SetBool("isRunning", false);
    }

    private void PlatformCheck()
    {
        if (/*YandexSDK.Instance.CurrentDeviceType == Assets.Yandex.DeviceTypeEnum.Desktop*/ ChoosePlatform.pcDevise == true)
        {
            joystick.gameObject.SetActive(false);
            gravityButton.SetActive(false);
            jumpButton.SetActive(false);

            tutorialA.SetActive(true);
            tutorialD.SetActive(true);
            tutorialB.SetActive(true);
            tutorialSpace.SetActive(true);
        }
        else if (/*YandexSDK.Instance.CurrentDeviceType == Assets.Yandex.DeviceTypeEnum.Mobile */ ChoosePlatform.pcDevise == false)
        {
            joystick.gameObject.SetActive(true);
            gravityButton.SetActive(true);
            jumpButton.SetActive(true);

            tutorialA.SetActive(false);
            tutorialD.SetActive(false);
            tutorialB.SetActive(false);
            tutorialSpace.SetActive(false);
        }
    }
}
