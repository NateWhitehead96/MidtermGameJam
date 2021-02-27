using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public bool counting;
    public Text timer;
    public Image[] stars;
    public Sprite[] starColors;
    private float seconds;
    private int minutes;
    // Start is called before the first frame update
    void Start()
    {
        counting = true;
        seconds = 0;
        minutes = 0;
        if (SceneManager.GetSceneByName("Level2") == SceneManager.GetActiveScene())
        {
            stars[0].sprite = starColors[0];
        }
        if (SceneManager.GetSceneByName("Level3") == SceneManager.GetActiveScene())
        {
            stars[0].sprite = starColors[0];
            stars[1].sprite = starColors[1];
        }
        if (SceneManager.GetSceneByName("Level4") == SceneManager.GetActiveScene())
        {
            stars[0].sprite = starColors[0];
            stars[1].sprite = starColors[1];
            stars[2].sprite = starColors[2];
        }
        if (SceneManager.GetSceneByName("BossLevel") == SceneManager.GetActiveScene())
        {
            stars[0].sprite = starColors[0];
            stars[1].sprite = starColors[1];
            stars[2].sprite = starColors[2];
            stars[3].sprite = starColors[3];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (counting)
        {
            if (seconds >= 60)
            {
                minutes += 1;
                seconds = 0;
            }
            seconds += 1 * Time.deltaTime;
            timer.text = "Time: " + minutes.ToString() + seconds.ToString("#:00");
        }
    }
}
