using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlaygGame()
    {
        SceneManager.LoadScene("baseLvl");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
