using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCube : Interactable
{
    // Start is called before the first frame update
    Animator animator;
    private string startPrompt;
    void Start()
    {
        animator = GetComponent<Animator>();
        startPrompt = promptMessage;
    }

    // Update is called once per frame
    void Update()
    {

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Default"))
       { promptMessage = startPrompt; }
    else            promptMessage = "Animating..";
 
    }
    protected override void Interact()
    {
        animator.SetTrigger("anim");
    }
}
