using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour
{
    public AudioSource BGM;
    private static MenuMusic _instance;
    public static MenuMusic isntance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<MenuMusic>();
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
        if (SceneManager.GetSceneByName("MainScene") == SceneManager.GetActiveScene())
        {
            print("yes");
            Destroy(gameObject);
        }
    }
}
