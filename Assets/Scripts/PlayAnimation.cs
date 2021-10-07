using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] string animationName;

    public void ReplayAnimation()
    {
        animator.Play(animationName, -1, 0.0f);
    }
}
