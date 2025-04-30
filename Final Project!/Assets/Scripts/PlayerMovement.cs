using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;



public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust speed in the Inspector
    private Rigidbody2D rb;
    private Vector2 moveInput;
    public float jump;
    public bool isjJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {// Get input from arrow keys or WASD
        moveInput.x = Input.GetAxisRaw("Horizontal");
        // Left (-1) / Right (1)
        moveInput.y = Input.GetAxisRaw("Vertical");
        // Down (-1) / Up (1)
        moveInput.Normalize();
        //Prevent faster diagonal movement 

        rb.velocity = moveInput * moveSpeed;
        {
            if (Input.GetButtonDown("Jump")) ;
            }
        rb.AddForce(new Vector2(rb.velocity.x, jump));
        {

        }
    } 
}
        
    

  
  




