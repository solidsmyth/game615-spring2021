using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float cameraSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.transform.Rotate(0, -cameraSpeed, 0);
        }
        else
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.transform.Rotate(0, 0, 0);

        }

        if (Input.GetKey(KeyCode.E))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.transform.Rotate(0, cameraSpeed, 0);
        }
        else
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.transform.Rotate(0, 0, 0);

        }

    }
}
