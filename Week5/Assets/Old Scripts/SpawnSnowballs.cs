using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowballs : MonoBehaviour
{
    public GameObject snowballPrefab;
    private GameObject cameraObj;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);
            // compute the new direction and set it;
            // this is just an example of "manually" computing a vector and setting it;
            // in the common case of looking at something, Unity has a built-in method;
            //Vector3 vectorToTarget = cameraObj.transform.position - transfrom.position;
            //vectorToTarget = vectorToTarget.normalized;
            // snoball.transform.forward = vectorToTarget;

            snowball.transform.LookAt(cameraObj.transform);

        }
      // preview of what we do here
      // check for keypress
      // if yes:
      //    Instantiate(snowballPrefab, position)
    }
    */
    }
    public void SpawnSnowball()
    {
        GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);

        snowball.transform.LookAt(cameraObj.transform);

    }
}
