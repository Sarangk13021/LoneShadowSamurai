using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private CapsuleCollider2D CapsuleCollider;
    private CircleCollider2D CircleCollider;
    private PlayerAttack playerattack;
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponentInParent<Rigidbody2D>();
        CapsuleCollider = GetComponentInParent<CapsuleCollider2D>();
        CircleCollider = GetComponentInParent<CircleCollider2D>();
        playerattack = GetComponentInParent<PlayerAttack>();
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
    public void AttackImpact()
    {
        playerattack.PerformAttackHit();
    }
    // -------- DEATH ----------
    public void PlayDeath()
    {
        anim.SetTrigger("Dead");
    }
    public void EnableCylinderCollider()
    {
        CapsuleCollider.enabled = true;
    }
    public void DisableCylinderCollider()
    {
        CapsuleCollider.enabled = false;
    }
    public void EnableDeathCollider()
    {
        CircleCollider.enabled = true;
        CapsuleCollider.enabled = true;
    }
    public void DisableDeathCollider()
    {
        CircleCollider.enabled = false;
        CapsuleCollider.enabled = false;
    }
    
}