using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement movement;     // A reference to our PlayerMovement script
	public BoxCollider2D BoxCollider2D;
	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "spike")
		{

            movement.enabled = false;
        }
		if (collisionInfo.collider.tag == "spike")
		{

			BoxCollider2D.enabled = false;
		}
	}

}