using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Globals", menuName = "Assets/Globals")]

public class Globals : ScriptableObject
{
    //Глобальные настройки игры

    //Количество очков за правильный ответ
    public int starPrice;

    //Начальное количество жизней
    public int initHealth;

    //Время для ответа в секундах
    public float time;

    //База предметов для игры
    public Stuff[] stuff;
}
