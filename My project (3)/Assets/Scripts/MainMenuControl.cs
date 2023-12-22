using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public GameObject mainMenuButtons;
    public GameObject mainMenuButtons2;
    public bool FirstActive = true;

    public virtual void ConfirmExit()
    {
        mainMenuButtons.SetActive(FirstActive?false:true);
        mainMenuButtons2.SetActive(FirstActive?true:false);

        FirstActive = FirstActive?false:true;
    }

    public virtual void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
