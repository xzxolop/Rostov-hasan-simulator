using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject optionMenu;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        startMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void QuitToMenu()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
    }
}
