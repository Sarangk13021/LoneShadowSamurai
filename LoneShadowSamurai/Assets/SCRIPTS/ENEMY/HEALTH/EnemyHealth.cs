using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int MaxHealth = 10;
    private int currentHealth;
    void Start()
    {
        currentHealth = MaxHealth;
    }
    void Update()
    {
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("health is reducing");
        if (currentHealth <= 0)
        {
            EnemyDeath();
        }
    }
    public void EnemyDeath()
    {
        Destroy(gameObject);
    }
}
