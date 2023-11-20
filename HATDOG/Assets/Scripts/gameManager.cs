using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject PauseUI;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void GameOver()
    {
        
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("game2");
        GameOverUI.SetActive(false);
        Time.timeScale = 1f;

    }

    public void MenuSelect()
    {
        SceneManager.LoadScene("menu");

    }

    public void ResumeGame()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Paused()
    {
        
        PauseUI.SetActive(true);
        Time.timeScale = 0f;

    }
}
