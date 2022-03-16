using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

    void fireball()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Destroy(enemy_test);
            Debug.Log("DESTROYED!");
        }
    }

}
