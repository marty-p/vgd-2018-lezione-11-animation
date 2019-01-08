using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour {

    private Animator animator;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("rotation", true);
        }

    }

    public void Event()
    {
        animator.SetBool("bounce", true);
        Debug.Log("Questo è un evento");
    }
}
