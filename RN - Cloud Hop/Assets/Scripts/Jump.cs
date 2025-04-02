using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUmp : MonoBehaviour { 

    private Rigidbody2D rb;                                                                                                                                                                                                                                                                                                                         
    private float jumpForce = 15;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("SIMGA BOYOIOIOII");   
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Jump") && rb.velocity.y ==0)
            {

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
