using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpStrength = 10f;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

  private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {

        isGrounded = Physics2D.OverlapCircle(
          groundCheck.position,
          groundCheckRadius,
          groundLayer
          );

        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * playerSpeed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpStrength);
           




        }
    }
}
