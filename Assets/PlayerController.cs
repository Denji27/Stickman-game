using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public float speed = 5f;
    // public float jumpForce = 7f;

    // private Rigidbody2D rb;

    // void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    // }

    // void Update()
    // {
    //     // Horizontal movement
    //     float move = Input.GetAxis("Horizontal");
    //     Debug.Log("move DETECTED " + move);
    //     rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

    //     // Jump on mouse click
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Debug.Log("CLICK DETECTED");

    //         rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    //     }
    // }

    public float speed = 5f;
    public float jumpForce = 7f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleJump();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }

    void HandleJump()
    {
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Ground"))
    //         isGrounded = true;
    // }

    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }

    if (collision.gameObject.CompareTag("Obstacle"))
    {
        GameManager.instance.GameOver();
    }
}

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}
