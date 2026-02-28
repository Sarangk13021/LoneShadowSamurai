using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponentInParent<Rigidbody2D>();
    }

    // -------- MOVE ----------
    public void UpdateMovement()
    {
        float speed = Mathf.Abs(rb.linearVelocity.x);

        if (speed > 0.1f)
            anim.SetBool("Move", true);
        else
            anim.SetBool("Move", false);
    }
    // -------- JUMP ----------
    public void PlayeDodge()
    {
        anim.SetTrigger("Dodge");
    }
    // -------- ATTACK ----------
    public void PlayAttack()
    {
        anim.SetTrigger("Attack");
    }
    // -------- DEATH ----------
    public void PlayDeath()
    {
        anim.SetTrigger("Dead");
    }
}