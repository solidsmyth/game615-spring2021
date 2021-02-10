using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;

            rb.AddForce(transform.forward * 1000.0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        { Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;

            rb.AddForce(transform.TransformDirection(Vector3.left) * 1000.0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;

            rb.AddForce(transform.TransformDirection(Vector3.right) * 1000.0f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;

            rb.AddForce(transform.TransformDirection(Vector3.back) * 1000.0f);
        }
    }
}
