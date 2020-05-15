using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoaderVM : MonoBehaviour
{
    void Update()
    {
        BacktoMainMenu();
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("Level 3");
        Time.timeScale = 1;
    }

    public void LoadPlayButton()
    {
        //SceneManager.LoadScene();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void LoadLevelMenu()
    {
        SceneManager.LoadScene("Level Menu");
    }

    public void LoadCredits()
    {
        //SceneManager.LoadScene();
    }

    public void LoadLevelOne()
    {
        //SceneManager.LoadScene();
    }

    public void LoadLevelTwo()
    {
        //SceneManager.LoadScene();
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void BacktoMainMenu()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Start Menu");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
