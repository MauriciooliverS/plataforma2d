using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{
    private float moveInput;
    public float moveSpeed;
    private Rigidbody2D rb2d;
    public float jumpForce;
    [SerializeField] private bool onGround;
    private bool wasonGround;
    private bool isJump;
    private Collider2D[] collider_1, collider_2;
    private float checkRadius = 0.1f;
    public Transform[] groundCheck;
    public Animator playerAnim;
    [SerializeField] private LayerMask groundMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        InputSistem();
        checkGround();
        Animations();
    }

private void Move()
{
    rb2d.linearVelocity = new UnityEngine.Vector2 (moveInput * moveSpeed, rb2d.linearVelocity.y);
}
void checkGround()
{
    collider_1 = Physics2D.OverlapCircleAll(groundCheck[0].position, checkRadius, groundMask);
    collider_2 = Physics2D.OverlapCircleAll(groundCheck[1].position, checkRadius, groundMask);

    if (collider_1.Length>0 || collider_2.Length>0)
    {
        onGround = true;
    }
    else
    {
        onGround = false;
    }
}
private void InputSistem()
{
    moveInput = Input.GetAxisRaw("Horizontal");
    if (moveInput != 0f)
    {
        transform.localScale = new UnityEngine.Vector3(moveInput,  1f, 1f);
    }
    if(Input.GetKeyDown(KeyCode.Space) && onGround)
    {
        Jump();
    }
}
private void Jump()
{
    rb2d.linearVelocity = new UnityEngine.Vector2 (rb2d.linearVelocity.x,jumpForce);
}

private void Animations()
{
    playerAnim.SetFloat("SpeedX", Mathf.Abs(moveInput));
    playerAnim.SetFloat("SpeedY", rb2d.linearVelocity.y);
    playerAnim.SetBool("onGround", onGround);
}
}