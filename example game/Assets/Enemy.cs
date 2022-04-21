using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioSource enemykuolema;
    public Animator animator;
    public Animator dooranimator;
    public int maxHealth = 100;
    int currentHealth;
    
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
