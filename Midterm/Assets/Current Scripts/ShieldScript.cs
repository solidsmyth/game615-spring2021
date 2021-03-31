using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldScript : MonoBehaviour
{
    public int shield;
    public Text txt;
    GameObject Recharge;
    // Start is called before the first frame update
    void Start()
    {
        shield = 0;

        txt.text = "Shield " + shield.ToString();

        Recharge = GameObject.Find("Player");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "UnbreakableWall" || col.gameObject.tag == "BreakableWall")
        {
            if (shield > 0)
            {
                shield = shield - 10;

                txt.text = "Shield " + shield.ToString();
            }
            else
            {
                shield = 0;

                txt.text = "Shield " + shield.ToString();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Recharge.GetComponent<ShieldPickUpScript>().recharge > 0)
        {
            shield = shield + Recharge.GetComponent<ShieldPickUpScript>().recharge;

            txt.text = "Shield " + shield.ToString();

            Recharge.GetComponent<ShieldPickUpScript>().recharge = 0;
        }
    }
}
