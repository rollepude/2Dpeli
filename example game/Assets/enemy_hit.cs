using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hit : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint;
    public LayerMask playerLayers;
    public float attackRange = 0.5f;

    public int attackDamage = 50;
    
        private void OnTriggerEnter2D(Collider2D other)
        {


            if (other.CompareTag("Player"))
            {

                Attack();

            }
        }
    

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent</*Player*/Enemy>().TakeDamage(attackDamage);

        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

