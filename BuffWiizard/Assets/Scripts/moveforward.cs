using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{

    public float speed;
    public float Hitpoints;
    public float MaxHitpoints = 2;

    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.position += new Vector3(-speed, 0, 0);
    }

}
