using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class failedExit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var enemy = collision.collider.GetComponent<moveforward>();
        if (enemy)
        {
            SceneManager.LoadScene("mainMenu");
        }
    }
}
