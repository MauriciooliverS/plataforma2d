using System.Numerics;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{
    private float moveInput;
    public float moveSpeed;
    private Rigidbody2D rb2d;
    public float jumpForce;
    [SerializeField] private bool onGround;
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
    }

private void Move()
{
    rb2d.linearVelocity = new UnityEngine.Vector2 (moveInput * moveSpeed, rb2d.linearVelocity.y);
}
private void InputSistem()
{
    moveInput = Input.GetAxisRaw("Horizontal");
    if (moveInput != 0f)
    {
        transform.localScale = new UnityEngine.Vector3(moveInput,  1f, 1f);
    }
}
}