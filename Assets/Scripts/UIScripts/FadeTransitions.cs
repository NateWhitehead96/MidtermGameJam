using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTransitions : MonoBehaviour
{
    private Animator animator;
    public bool finished;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFadeOut()
    {
        animator.SetBool("NewScene", true);
    }

   
}
