using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float JumpForce = 10f;
    public Transform GroundCheck;
    public LayerMask GroundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool jumprequest;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumprequest = true;
        }
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
        
            if (jumprequest && isGrounded)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
            }
        jumprequest = false;
    }
    public void JumpButton()
    {
        if(isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
        }
    }
}
