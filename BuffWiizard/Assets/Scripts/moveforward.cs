using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    GameObject enemy;

    void Start()
    {

    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

    void destroytest()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("enemy"))
        {
            // Destroy(gameObject);
            // Debug.Log("DESTROYED!");
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            // Casts the ray and get the first game object hit
            //Physics.Raycast(ray, out hit);
            //Destroy(gameObject);
        }
    }

}
