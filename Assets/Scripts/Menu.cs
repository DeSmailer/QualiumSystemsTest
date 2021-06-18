using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject startCanvas;
    [SerializeField]
    private GameObject restartCanvas;
    [SerializeField]
    private Timer timer;

    private void Start()
    {
        ToStartMenu();
    }

    private void EnableAll()
    {
        Time.timeScale = 0f;
        startCanvas.SetActive(false);
        restartCanvas.SetActive(false);
    }

    public void ToStartMenu()
    {
        EnableAll();
        startCanvas.SetActive(true);
    }
    public void ToRestartMenu()
    {
        EnableAll();
        restartCanvas.SetActive(true);
    }

    public void StartGame()
    {
        EnableAll();
        timer.Restart();
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
