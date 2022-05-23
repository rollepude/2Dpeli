using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public BoxCollider2D Box;
    public AudioSource enemykuolema;
    public Animator animator;
    public Animator attackanimator;
    public Animator dooranimator;
    public int maxHealth = 100;
    int currentHealth;
    
   


 


  
    

    void Start()
    {
        currentHealth = maxHealth;
        Box.enabled = false;
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
       
        Debug.Log("Enemy died");
        animator.SetBool("IsDead", true);
        Box.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        dooranimator.SetBool("kuolema", true);
    }
}
