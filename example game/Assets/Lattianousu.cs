using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lattianousu : MonoBehaviour
{
	[SerializeField] private Animator MyAnimatorController;
	[SerializeField] private Animator MyanimatorController;
	[SerializeField] private Animator Myanimatorcontroller;
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			MyAnimatorController.SetBool("Lattianousu", true);
			MyanimatorController.SetBool("Piikkinousu", true);
			Myanimatorcontroller.SetBool("seinänousu", true);
		}
	}


  //  private void OnTriggerExit2D(Collider2D other)
  //  {
  //      if (other.CompareTag("Player"))
  //      {
  //          MyAnimatorController.SetBool("Lattianousu", false);
  //          MyanimatorController.SetBool("Piikkinousu", false);
		//	Myanimatorcontroller.SetBool("seinänousu", false);
		//}
  //  }
}
