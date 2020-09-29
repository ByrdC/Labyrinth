using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PausePanel;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
