using UnityEngine;
using UnityEngine.Events;
public class PlayerCollision : MonoBehaviour
{
	
	public Rigidbody2D rb;
	public PlayerMovement movement;     // A reference to our PlayerMovement script
	public BoxCollider2D BoxCollider2D;
	public Animator animator;

    
    public AudioSource Levelcomplete;
    public AudioSource playSound;
    public AudioSource pauseSound;
    void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "spike")
		{
            playSound.Play();
            movement.enabled = false;
            
            pauseSound.Pause();
        }
        //if (collisionInfo.collider.tag == "spike")
        //{

        //	BoxCollider2D.enabled = false;
        //}

        if (collisionInfo.transform.tag == "spike")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
        if (collisionInfo.collider.tag == "spike")
		{
			animator.enabled = false;

		}
        if (collisionInfo.collider.tag == "j‰‰dytys")
        {
            animator.SetBool("IsJumping", false);
            animator.SetFloat("Speed", 0);
            
            animator.ResetTrigger("Attack");
            
            movement.enabled = false;
            pauseSound.Pause();
            Levelcomplete.Play();
        }
    }
 

}