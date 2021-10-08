using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Учитывает коичество жизней игрока

    //Текущее количество жизней
    int health;

    [SerializeField] Heart heartPrefab;
    [SerializeField] Globals globals;
    [SerializeField] Transform healthPanel;
    [SerializeField] GameEvent gameOver;

    List<Heart> heartPool = new List<Heart>();

    private void Start()
    {
        //Установка жизней в зависимости от глобальных настроек
        health = globals.initHealth;

        //Построение UI панели жизней
        GenerateHealthPanel();
    }

    //Сброс настроек при перезапуске игры
    public void HealthReset()
    {
        health = globals.initHealth;
        foreach (Heart heart in heartPool) heart.On();
    }

    //Обработка при неверном ответе
    public void ReduceHealth()
    {
        health--;

        //Выключаем индикатор-сердечко в UI
        heartPool[health].Off();

        //Запуск события при окончании жизней
        if (health == 0) gameOver.Raise();
    }

    //Генерация необходимого количества индикаторов-сердечек для UI
    private void GenerateHealthPanel()
    {
        for(int i = 0; i < globals.initHealth; i++)
        {
            Heart newHeart = Instantiate(heartPrefab, healthPanel);
            heartPool.Add(newHeart);
        }
    }
}
