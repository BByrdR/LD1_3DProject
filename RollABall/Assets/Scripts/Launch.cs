using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public GameObject LaunchPad;
    public int force = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        GameObject launch = collision.gameObject;
        Rigidbody rb = launch.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * force);
    }
}
