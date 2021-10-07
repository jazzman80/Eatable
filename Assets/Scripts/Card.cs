using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    public enum Quality
    {
        eatable,
        uneatable
    }
    
    [SerializeField] Animator animator;
    [SerializeField] GameEvent cardDestroy;
    [SerializeField] GameEvent guessedRight;
    [SerializeField] GameEvent guessedWrong;

    bool active = false;
    Quality quality;

    public void SetData(Quality setQuality)
    {
        quality = setQuality;
    }

    public void OnSwipeLeft()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Left");
        }

        if (quality == Quality.uneatable) guessedRight.Raise();
        else guessedWrong.Raise();
    }

    public void OnSwipeRight()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Right");
        }

        if (quality == Quality.eatable) guessedRight.Raise();
        else guessedWrong.Raise();
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
