using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarBehaviour : MonoBehaviour
{
    public int nextLevel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fading());
        }
        // show some UI to go to next level but for now just insta port there
    }
    IEnumerator Fading()
    {
        FindObjectOfType<FadeTransitions>().PlayFadeOut();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextLevel);
    }
}
