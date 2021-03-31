using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    //win condition
    public bool tutorial1 = false;

    //FrameTimer

    private bool Timer = false;
    private int end;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        end = 5000;

        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer == true)
        {
            end = end - 1;
            if (end <= 0)
            {
                tutorial1 = false;
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tutorial1")
        {
            tutorial1 = true;

            Timer = true;

            Player.GetComponent<Tutorial2Script>().tutorial2 = false;
            Player.GetComponent<Tutorial3Script>().tutorial3 = false;
            Player.GetComponent<Tutorial4Script>().tutorial4 = false;
        }
    }
    private void OnGUI()
    {

        if (tutorial1)
        {
            GUI.Label(new Rect(250, 250, 200, 200), "Welcome! Use the WASD keys to move your character. Use Q and E to move the camera. Use Spacebar to fire your weapon. Check your surroundings for additional tutorials.");

        }
        else
        {

        }
    }
}
