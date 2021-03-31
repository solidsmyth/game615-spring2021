using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPickUpScript : MonoBehaviour
{
    GameObject Player;
    public int heal;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Health")
        {

            heal = heal + 20;

            Destroy(col.gameObject);

            Debug.Log("recharge");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
