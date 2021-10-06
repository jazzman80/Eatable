﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] Globals globals;
    [SerializeField] GameEvent timeOver;
    [SerializeField] Animator animator;

    private void Start()
    {
        animator.speed = 1 / globals.time;
        StartCoroutine(CardTime());
    }

    public void StartTimer()
    {
        StopAllCoroutines();
        StartCoroutine(CardTime());
    }

    public void StopTimer()
    {
        StopAllCoroutines();
    }

    private IEnumerator CardTime()
    {
        animator.Play("Timer Bar", -1, 0.0f);
        yield return new WaitForSeconds(globals.time);
        timeOver.Raise();
    }
}
