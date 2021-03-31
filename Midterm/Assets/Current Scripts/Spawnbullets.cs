using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawnbullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject Player;
    private GameObject cameraObj;
    private int FrameTimer;
    public int ammo;
    public Text txt;
    GameObject PickUp;

    // Start is called before the first frame update
    void Start()
    {
        PickUp = GameObject.Find("Player");

        cameraObj = GameObject.Find("Main Camera");

        ammo = 3;

        txt.text = "Ammo " + ammo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            Rigidbody PlayerBody = Player.GetComponent<Rigidbody>();

            PlayerBody.isKinematic = true;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            FrameTimer = 10;

            ammo = ammo - 1;

            txt.text = "Ammo " + ammo.ToString();

            Debug.Log("kinematic working");
        }
        else
        {
            if (FrameTimer >= 1) {

                FrameTimer = FrameTimer - 1;

            }
            else
            {
                Rigidbody PlayerBody = Player.GetComponent<Rigidbody>();

                PlayerBody.isKinematic = false;
            }
        }

        if (PickUp.GetComponent<AmmoPickUpScript>().reload > 0)
        {
            ammo = ammo + PickUp.GetComponent<AmmoPickUpScript>().reload;

            txt.text = "Ammo " + ammo.ToString();

            PickUp.GetComponent<AmmoPickUpScript>().reload = 0;

            Debug.Log("Reloaded");
            if (ammo >= 6)
            {
                ammo = 6;

                txt.text = "Ammo " + ammo.ToString();
            }
        }


    }

}

