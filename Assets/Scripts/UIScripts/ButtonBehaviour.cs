using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnPlay()
    {
        StartCoroutine(Play());
    }
    IEnumerator Play()
    {
        FindObjectOfType<FadeTransitions>().PlayFadeOut();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MainScene");
    }

    public void OnControls()
    {
        StartCoroutine(Controls());
    }
    IEnumerator Controls()
    {
        FindObjectOfType<FadeTransitions>().PlayFadeOut();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Controls");
    }

    public void OnCredits()
    {
        StartCoroutine(Credits());  
    }
    IEnumerator Credits()
    {
        FindObjectOfType<FadeTransitions>().PlayFadeOut();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Credits");
    }

    public void OnBack()
    {
        StartCoroutine(Back());
    }
    IEnumerator Back()
    {
        FindObjectOfType<FadeTransitions>().PlayFadeOut();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MainMenu");
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
