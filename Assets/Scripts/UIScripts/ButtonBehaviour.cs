using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void OnBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
