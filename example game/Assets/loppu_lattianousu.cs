using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loppu_lattianousu : MonoBehaviour
{
	
	[SerializeField] private Animator MyAnimatorController;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			
			MyAnimatorController.SetBool("lattianousu", true);
			
		}
	}
}
