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
    [SerializeField] TextMeshPro caption;

    bool active = false;
    Quality quality;

    public void SetData(Quality setQuality)
    {
        quality = setQuality;

        caption.text = quality.ToString();
    }

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
