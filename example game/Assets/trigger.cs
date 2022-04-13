using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
   
    [SerializeField] private Animator piikkikäännösController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger"))
        {
            piikkikäännösController.SetBool("käännös", true);
            
        }
    }

}
