using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    private GameplayUI gameplayUI;
    private void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            gameplayUI = FindObjectOfType<GameplayUI>();
        }
    }
    public void Resume()
    {
        gameplayUI.isOpened = false;
        gameplayUI.pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        gameplayUI.isOpened = true;
        gameplayUI.pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

	public void Quit()
	{
		Application.Quit();
	}

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowLoseMenu()
    {
        gameplayUI.isOpened = true;
        gameplayUI.loseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
    }
}
