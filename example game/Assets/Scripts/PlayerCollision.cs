using UnityEngine;
using UnityEngine.Events;
public class PlayerCollision : MonoBehaviour
{
	public float moveSpeed = 5;
	public Rigidbody2D rb;
	public PlayerMovement movement;     // A reference to our PlayerMovement script
	public BoxCollider2D BoxCollider2D;

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> {
	
	}

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();

		if (OnLandEvent == null)
			OnLandEvent = new UnityEvent();
	}

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
		if (collisionInfo.collider.tag == "jaa")
		{
			rb.AddForce(new Vector2(moveSpeed, 1));

		}
	}

}