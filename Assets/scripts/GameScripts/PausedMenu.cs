using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenu;
    public GameObject PauseOptionMenu;


    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }
    void Stop()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void Play()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Cursor.visible = false;
    }

    public void MainMenueButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Options()
    {
        PauseMenu.SetActive(false );
        PauseOptionMenu.SetActive(true);
    }

}
