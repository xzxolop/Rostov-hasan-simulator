using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject optionMenu;

   

    public void QuitToMenu()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
    }


    public Toggle fullscreenToggle; // ������ Toggle ��� ��������� �������������� ������

    public void FullScreen()
    {
        Screen.fullScreen = fullscreenToggle.isOn; // �������� ��������� �������������� ������ Unity � ����������� �� ��������� �������������
    }



}
