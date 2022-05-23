using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_active : MonoBehaviour
{
    [SerializeField] private Animator MyAnimatorController;
	public AudioSource ovi;
	//public AudioSource nauru;
	public GameObject Enemy;
	
	void Start()
    {
        Enemy.SetActive(false);
    }
	
	
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			MyAnimatorController.SetBool("kiinni", true);
			ovi.Play();
			Enemy.SetActive(true);
			//nauru.Play();
			gameObject.SetActive(false);
		}
	}
}
