using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
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

    void Update()
    {
        float horizotalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizotalInput * speed, body.velocity.y);

        //Pelaaja k��ntyy ku h�n liikkuu oikeelta vasemmalle
        if (horizotalInput > 0.01f)
            transform.localScale = new Vector3(3, 3, 1);
        else if (horizotalInput < -0.01f)
            transform.localScale = new Vector3(-3, 3, 1);

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

       
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

        }
    }
  


}