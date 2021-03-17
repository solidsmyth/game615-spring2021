using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "UnbreakableWall")
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(0, 0, 0);

            Debug.Log("isworking");
        }
        if (col.gameObject.tag == "BreakableWall")
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(0, 0, 0);
        }

    }
}
