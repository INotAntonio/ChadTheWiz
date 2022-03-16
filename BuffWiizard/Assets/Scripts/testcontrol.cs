using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcontrol : MonoBehaviour
{
    void Update()
    {
        //Detect if the right mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("did something");
            Destroy(gameObject);
        }
    }
}
