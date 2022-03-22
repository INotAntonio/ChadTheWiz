using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class moveforward : MonoBehaviour
{

    public float speed;
    public float Hitpoints;
    public float MaxHitpoints = 2;
    public healthbarBehaviour Healthbar;

    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
            //SceneManager.LoadScene("mainMenu");
        }
    }

    private void Update()
    {
        transform.position += new Vector3(-speed, 0, 0);
    }

}
