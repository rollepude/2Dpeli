using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lattianousu : MonoBehaviour
{
	public AudioSource lattia;
	public AudioSource nauru;
	[SerializeField] private Animator MyAnimatorController;
	[SerializeField] private Animator MyanimatorController;
	[SerializeField] private Animator Myanimatorcontroller;
	[SerializeField] private Animator piikkik��nn�scontroller;
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			lattia.Play();
			nauru.Play();
			MyAnimatorController.SetBool("Lattianousu", true);
			MyanimatorController.SetBool("Piikkinousu", true);
			Myanimatorcontroller.SetBool("sein�nousu", true);
			piikkik��nn�scontroller.SetBool("k��nn�s", true);
			gameObject.SetActive(false);
		}
	}


  //  private void OnTriggerExit2D(Collider2D other)
  //  {
  //      if (other.CompareTag("Player"))
  //      {
  //          MyAnimatorController.SetBool("Lattianousu", false);
  //          MyanimatorController.SetBool("Piikkinousu", false);
		//	Myanimatorcontroller.SetBool("sein�nousu", false);
		//}
  //  }
}
