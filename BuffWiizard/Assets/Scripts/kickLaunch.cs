using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickLaunch : MonoBehaviour
{
    //public float Speed = 5f;

    void Update()
    {
        //transform.position += transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var enemy = collision.collider.GetComponent<moveforward>();
        if (enemy)
        {
            enemy.TakeHit(4);
        }

        Destroy(gameObject);
    }
}
