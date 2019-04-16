using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float moveInput;
    SpriteRenderer sr;
    private Rigidbody2D rb;
    private int[] arrayOefenen;

    private int extraJump;
    public int extraJumpValue;

    private bool facingRight = true;

    private bool isGrounded;

    public Transform groundCheck;

    public float checkRadius;

    public LayerMask whatIsGround;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        extraJump = extraJumpValue;
        arrayOefenen = new int[10];
        arrayOefenen[1] = 12;
        arrayOefenen[4] = 65;
        arrayOefenen[7] = 89;
        for (int i = 0; i < arrayOefenen.Length; i++) {
            Debug.Log(arrayOefenen[i]);
        }
    }

    void Update()
    {
        if (isGrounded) {
            extraJump = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.Space)&& extraJump > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }/*else if(Input.GetKeyDown(KeyCode.Space) && extraJump == 0) {
            rb.velocity = Vector2.up * jumpForce;
        }*/
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput >0) {
            Flip();
        } else if(facingRight == true && moveInput < 0) {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        sr.flipX = !facingRight;
    }
}
