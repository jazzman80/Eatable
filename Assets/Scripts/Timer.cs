using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Таймер для отсчёта времени на одну карточку
    
    [SerializeField] Globals globals;
    [SerializeField] GameEvent timeOver;
    [SerializeField] Animator animator;
    [SerializeField] GameObject timerUI;

    private void Start()
    {
        //Установка скорости работы UI таймера
        animator.speed = 1 / globals.time;
        //Запуск таймера
        StartCoroutine(CardTime());
    }

    //Перезапуск таймера
    public void StartTimer()
    {
        StopAllCoroutines();
        StartCoroutine(CardTime());
    }

    //Остановка таймера - исползуется при Game Over
    public void StopTimer()
    {
        StopAllCoroutines();
        timerUI.SetActive(false);
    }

    private IEnumerator CardTime()
    {
        //Перезапуск UI
        animator.Play("Timer Bar", -1, 0.0f);

        yield return new WaitForSeconds(globals.time);
        //Запуск события "время закончилось"
        timeOver.Raise();
    }

    //Включение UI при перезапуске игры
    public void ActivateUI()
    {
        timerUI.SetActive(true);
    }

}
