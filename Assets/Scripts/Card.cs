using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameEvent cardDestroy;

    bool active = false;

    public void OnSwipeLeft()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Left");
        }
    }

    public void OnSwipeRight()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Right");
        }
    }

    public void Activate()
    {
        active = true;
    }

    public void CardDestroy()
    {
        cardDestroy.Raise();
        Destroy(gameObject);
    }
}
