using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void OnSwipeLeft()
    {
        animator.Play("Swipe Left");
    }

    public void OnSwipeRight()
    {
        animator.Play("Swipe Right");
    }
}
