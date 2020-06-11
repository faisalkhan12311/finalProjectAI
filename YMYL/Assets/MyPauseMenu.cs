using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyPauseMenu : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameIsPaused)
            {
                Pause();
            }
            
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        //resuming time
        Time.timeScale = 1f;
        gameIsPaused = false;
        //removing cursor from game screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        //stopping game time
        Time.timeScale = 0f;
        gameIsPaused = true;
        //displaying cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void loadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("loadingMainMenu");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Debug.Log("quitting");
        Application.Quit();
    }
}
