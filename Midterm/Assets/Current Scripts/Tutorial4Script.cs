using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial4Script : MonoBehaviour
{
    //win condition
    public bool tutorial4 = false;

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
                tutorial4 = false;
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tutorial4")
        {
            tutorial4 = true;

            Timer = true;

            Player.GetComponent<TutorialScript>().tutorial1 = false;
            Player.GetComponent<Tutorial2Script>().tutorial2 = false;
            Player.GetComponent<Tutorial3Script>().tutorial3 = false;
        }
    }
    private void OnGUI()
    {

        if (tutorial4)
        {
            GUI.Label(new Rect(250, 250, 200, 200), "This is a toolbox. Pick this up to restore your any lost health, as seen in the top left. If you pick this up while at maximum health (100), you will gain Overhealing, increasing your max health for a short period of time.");

        }
        else
        {

        }
    }
}