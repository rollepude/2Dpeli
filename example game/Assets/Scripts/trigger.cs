using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
   
    [SerializeField] private Animator piikkik��nn�sController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger"))
        {
            piikkik��nn�sController.SetBool("k��nn�s", true);
            
        }
    }

}
