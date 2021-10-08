using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    //Класс индикатора-сердечка для UI
    //В зависимости от глобальных настроек количества жизней
    //инстанциируется разное количество сердечек в меню

    [SerializeField] GameObject heart;

    //Выключение при потере жизни
    public void Off()
    {
        heart.SetActive(false);
    }

    //Включение при перезапуске игры
    public void On()
    {
        heart.SetActive(true);
    }
}
