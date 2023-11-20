using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
   public void gameStart()
    {
        SceneManager.LoadScene("game2");

    }

    public void gameExit()
    {
        Application.Quit();
    }
}
