using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioSource enemykuolema;
    public Animator animator;
    public Animator attackanimator;
    public Animator dooranimator;
    public int maxHealth = 100;
    int currentHealth;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        attackanimator.SetBool(("attack"), true);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }
   void Die()
    {
        enemykuolema.Play();
        Debug.Log("Enemy died");
        animator.SetBool("IsDead", true);
        
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        dooranimator.SetBool("kuolema", true);
    }
}
