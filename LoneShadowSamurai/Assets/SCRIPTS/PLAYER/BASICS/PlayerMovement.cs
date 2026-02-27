using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float MoveSpeed = 5f;
    private float Horizontal;
    private Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void SetHorizontal(float value)
    {
        Horizontal = value;
    }
    void FixedUpdate()
    {
        float VelocityY = rb.linearVelocity.y;
        rb.linearVelocity = new Vector2(Horizontal * MoveSpeed, VelocityY);
    }

}
