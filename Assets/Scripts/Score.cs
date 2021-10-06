using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score;

    [SerializeField] TextMeshProUGUI scoreUI;

    public void AddScore()
    {
        score += 10;

        scoreUI.text = score.ToString();
    }
}
