using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationResponse : Response
{
    [SerializeField]
    private string animat = "";

    private Animator animator = null;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public override void Respond()
    {
        if (animator != null)
        {
            animator.Play(animat);
        }
    }
}
