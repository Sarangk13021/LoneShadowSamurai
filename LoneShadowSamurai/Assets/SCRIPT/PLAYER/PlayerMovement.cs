using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float MoveSpeed = 10f;
    private float horizontal;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * MoveSpeed, rb.linearVelocity.y);
    }

    public void SetMovement(float input)
    {
        horizontal = input;
    }
}