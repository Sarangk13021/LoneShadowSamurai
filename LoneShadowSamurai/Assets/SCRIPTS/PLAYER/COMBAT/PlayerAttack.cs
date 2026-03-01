using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform attackPoint;
    private float attackRange = 0.17f;
    [SerializeField] private int attackDmg = 2;
    [SerializeField] private LayerMask enemyLayer;
    private PlayerAnimation playerAnimation;
    void Awake()
    {
        playerAnimation = GetComponentInChildren<PlayerAnimation>();
    }
    void Update()
    {

    }
    public void Attack()
    {
        playerAnimation.PlayAttack();
    }
    public void PerformAttackHit()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
        foreach (Collider2D enemy in hitEnemies)
        {
            EnemyHealth health = enemy.GetComponent<EnemyHealth>();
            if (health != null)
            {
                health.TakeDamage(attackDmg);
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
