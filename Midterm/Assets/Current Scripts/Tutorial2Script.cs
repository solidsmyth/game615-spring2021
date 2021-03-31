using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2Script : MonoBehaviour
{
    //win condition
    public bool tutorial2 = false;

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
                tutorial2 = false;
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tutorial2")
        {
            tutorial2 = true;

            Timer = true;

            Player.GetComponent<TutorialScript>().tutorial1 = false;
            Player.GetComponent<Tutorial3Script>().tutorial3 = false;
            Player.GetComponent<Tutorial4Script>().tutorial4 = false;
        }
    }
    private void OnGUI()
    {

        if (tutorial2)
        {
            GUI.Label(new Rect(250, 250, 200, 200), "In front of you is ammunition. Picking it up will refill your weapon up to a maximum of 6 shots, as seen in the top left corner. The shots fired from your weapon can be used to break down the yellow walls, though your shots will be destroyed on contact with the black walls.");

        }
        else
        {

        }
    }
}