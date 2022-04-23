using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    
    public Animator animator;
    public Rigidbody2D rb;
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
   
    public float moveSpeed;
    public float jumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode strike;

    private Rigidbody2D theRB;

    public Transform groundCheckPoint;
    
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public bool isGrounded;

    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
       
    }

    //public void OnLanding()
    //{
    //    animator.SetBool("IsJumping", false);
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        

        float horizotalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizotalInput * speed, body.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizotalInput));
        //Pelaaja kääntyy ku hän liikkuu oikeelta vasemmalle
        if (horizotalInput > 0.01f)
            transform.localScale = new Vector3(3, 3, 1);
        else if (horizotalInput < -0.01f)
            transform.localScale = new Vector3(-3, 3, 1);
        
        bool wasOnGround = isGrounded;
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
        
        if (!wasOnGround && isGrounded)
        {
            animator.SetBool("IsJumping", false);
        }
        if (Input.GetKey(left))
        {
           
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
           
        }

       

        else if (Input.GetKey(right))
        {
           
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
            
        }
        else
        {
            theRB.velocity = new Vector2(0, theRB.velocity.y);

        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            animator.SetBool("IsJumping", true);
        }
        //else
        //{
        //    animator.SetBool("IsJumping", false);
        //}
    }
    void OnDrawGizmosSelected()
    {
       
        Gizmos.DrawWireSphere(groundCheckPoint.position, groundCheckRadius);
    }


}