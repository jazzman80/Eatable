using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    //Класс индикатора-звёздочки при правильном ответе

    [SerializeField] Score score;

    //Обновить счёт по окончании анимации
    public void OnAnimationEnd()
    {
        score.UpdateScore();
    }
}
