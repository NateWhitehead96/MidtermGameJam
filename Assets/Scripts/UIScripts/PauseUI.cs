using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public void OnResume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void OnMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
