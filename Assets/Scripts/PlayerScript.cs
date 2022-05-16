using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Dance(bool isSoundOn)
    {
        animator.SetBool("isSoundOn", isSoundOn);
    }
    
    public void Run()
    {
        animator.SetBool("isPlayPressed", true);
    }
}
