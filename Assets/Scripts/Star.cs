using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] Score score;

    public void OnAnimationEnd()
    {
        score.UpdateScore();
    }
}
