using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial3Script : MonoBehaviour
{
    //win condition
    public bool tutorial3 = false;

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
                tutorial3 = false;
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tutorial3")
        {
            tutorial3 = true;

            Timer = true;

            Player.GetComponent<TutorialScript>().tutorial1 = false;
            Player.GetComponent<Tutorial2Script>().tutorial2 = false;
            Player.GetComponent<Tutorial4Script>().tutorial4 = false;
        }
    }
    private void OnGUI()
    {

        if (tutorial3)
        {
            GUI.Label(new Rect(250, 250, 200, 200), "This is a battery. Pick this up to increase your shields, as seen in the top left corner. When you have shields, they will take damage instead of your health, allowing you more time to survive.");

        }
        else
        {

        }
    }
}