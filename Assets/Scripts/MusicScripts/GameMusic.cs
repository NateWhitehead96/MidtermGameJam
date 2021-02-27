using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour
{
    public AudioSource BGM;
    private static GameMusic _instance;
    public static GameMusic isntance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameMusic>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
            BGM.Play();
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }//BGM.Play();



    }

    // Update is called once per frame
    private void Update()
    {
        if (SceneManager.GetSceneByName("MainMenu") == SceneManager.GetActiveScene() || SceneManager.GetSceneByName("BossLevel") == SceneManager.GetActiveScene())
        {
            print("yes");
            Destroy(gameObject);
        }
    }
}
