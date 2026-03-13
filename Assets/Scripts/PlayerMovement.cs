using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;  //controls animation flipping 

    public float Jump = 10f;
    public float HorizontalSpeed = 6f;  
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();       //gets components attatched  to player 
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * HorizontalSpeed, rb.linearVelocity.y);   //reads input keys

        if (sr != null && move != 0)
            sr.flipX = (move > 0);
        if (animator != null)
            animator.SetBool("isWalking", move != 0);

    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, Jump); //jumps when space clicked 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))  //allows jumping only when player is on ground 
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;                         //player cant jump when in air
    }
}

