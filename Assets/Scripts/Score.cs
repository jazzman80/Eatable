using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //Учёт очков

    //Текущий счёт
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreUI;
    [SerializeField] TextMeshProUGUI gameOverScore;
    [SerializeField] Globals globals;

    //Добавляем очки при правильном ответе
    public void AddScore()
    {
        score += globals.starPrice;
    }

    //Перезапуск при повторной игре
    public void ResetScore()
    {
        score = 0;
        UpdateScore();
    }

    //Вывод счёта в меню при окончании игры
    public void ShowGameOverScore()
    {
        gameOverScore.text = "счёт: " + score.ToString();
    }

    //Обновление счёта в UI - запускается после окончания анимации звездочки
    public void UpdateScore()
    {
        scoreUI.text = score.ToString();
    }
}
