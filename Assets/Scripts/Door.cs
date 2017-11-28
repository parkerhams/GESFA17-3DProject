using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable {
    //Door must know about animator compenent to set the bool IsOpen
    private Animator animator;

    public void DoActivate()
    {
        animator.SetBool("IsOpen", true);
    }
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
}
