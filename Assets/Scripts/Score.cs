using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreUI;
    [SerializeField] TextMeshProUGUI gameOverScore;
    [SerializeField] Globals globals;

    public void AddScore()
    {
        score += globals.starPrice;
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScore();
    }

    public void ShowGameOverScore()
    {
        gameOverScore.text = "счёт: " + score.ToString();
    }

    public void UpdateScore()
    {
        scoreUI.text = score.ToString();
    }
}
