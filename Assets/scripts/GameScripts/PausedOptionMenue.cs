using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedOptionMenue : MonoBehaviour
{
    public GameObject pauseMenue;
    public GameObject pauseOptionMenue;


    public void QuitToMenue()
    {
        pauseMenue.SetActive(true);
        pauseOptionMenue.SetActive(false);
    }

    public Toggle fullscreenToggle; // ������ Toggle ��� ��������� �������������� ������

    public void FullScreen()
    {
        Screen.fullScreen = fullscreenToggle.isOn; // �������� ��������� �������������� ������ Unity � ����������� �� ��������� �������������
    }
}
