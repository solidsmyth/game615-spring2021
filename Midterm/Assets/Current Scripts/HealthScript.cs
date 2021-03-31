using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    GameObject Player;
    public int health;
    public Text txt;
    GameObject HealUp;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;

        txt.text = "Health " + health.ToString();

        Player = GameObject.Find("Player");

        HealUp = GameObject.Find("Player");
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "UnbreakableWall" || col.gameObject.tag == "BreakableWall") 
            {
            if (Player.GetComponent<ShieldScript>().shield <= 0)
            {
                health = health - 10;

                txt.text = "Health " + health.ToString();
                if (health <= 0)
                {
                    Destroy(Player);
                }
                else
                {

                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (HealUp.GetComponent<HealthPickUpScript>().heal > 0)
        {
            health = health + HealUp.GetComponent<HealthPickUpScript>().heal;

            txt.text = "Health " + health.ToString();

            HealUp.GetComponent<HealthPickUpScript>().heal = 0;
            
            if (health > 100)
            {
                health = health - 1;
            }
            else
            {

            }
        }
    }
}
