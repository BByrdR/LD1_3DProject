using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpAmount = 3;
    private bool canJump;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        canJump = true;
    }

    void OnCollisionExit(Collision other)
    {
        canJump = false;
    }
}
