using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject optionMenu;

    //для изменения разрешения (на будущее)
    /*
    public Dropdown ResDrop;
    Resolution[] resolutions;
    void Start()
    {
        resolutions = Screen.resolutions;
        ResDrop.ClearOptions();
        List<string> options = new List<string>();

        for(int i = 0;i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
        }
        ResDrop.AddOptions(options);
    }
    */

    public void QuitToMenu()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
    }


    public Toggle fullscreenToggle; // объект Toggle для изменения полноэкранного режима

    public void FullScreen()
    {
        Screen.fullScreen = fullscreenToggle.isOn; // изменяем настройку полноэкранного режима Unity в зависимости от состояния переключателя
    }



}
