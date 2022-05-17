using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationResponse : Response
{
    [SerializeField]
    private string animat = "";

    private Animator animator = null;

    [SerializeField]
    private List<string> nextAnim = new List<string>();
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public override void Respond()
    {
        if (animator != null)
        {
            animator.Play(animat);

            if(nextAnim.Count > 0)
            {
                animat = nextAnim[0];
                nextAnim.RemoveAt(0);
                nextAnim.Add(animat);
            }
        }
    }
}
