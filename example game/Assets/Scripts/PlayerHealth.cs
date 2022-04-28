using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject enemy;
    public Animator animator;
    public AudioSource pauseSound;
    public AudioSource playSound;
    public AudioSource hitSound;
    public int maxHealth = 100;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        hitSound.Play();
        animator.SetTrigger("Hurt");
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        gameObject.SetActive(false);
       
        this.enabled = false;
        enemy.SetActive(false);
        animator.enabled = false;
        pauseSound.Pause();
        playSound.Play();
        Debug.Log("Enemy died");
        PlayerManager.isGameOver = true;

    }
}
