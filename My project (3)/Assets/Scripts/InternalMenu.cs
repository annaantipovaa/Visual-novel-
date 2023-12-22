using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InternalMenu : MainMenuControl
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject menuPause;
    public GameObject dialogLogPanel;

    public override void ConfirmExit()
    {
        panel2.SetActive(FirstActive ? false : true);
        mainMenuButtons2.SetActive(FirstActive ? false : true);

        FirstActive = FirstActive ? false : true;
    }

    public void Resume2()
    {
        panel2.SetActive(FirstActive ? true : false);
        mainMenuButtons2.SetActive(FirstActive ? true : false);

        FirstActive = FirstActive ? false : true;
    }

    public override void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        panel.SetActive(FirstActive ? true : false);
        menuPause.SetActive(FirstActive ? true : false);
        mainMenuButtons.SetActive(FirstActive ? true : false);

        FirstActive = FirstActive ? false : true;
    }

    public void PauseGame()
    {
        panel.SetActive(FirstActive ? false : true);
        menuPause.SetActive(FirstActive ? false : true);
        mainMenuButtons.SetActive(FirstActive ? false : true);

        FirstActive = FirstActive ? false : true;
    }

    public void OpenDialogueLog()
    {
        dialogLogPanel.SetActive(FirstActive ? true : false);

        FirstActive = FirstActive ? false : true;
    }

}
