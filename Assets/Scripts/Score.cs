using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score;

    [SerializeField] TextMeshProUGUI scoreUI;
    [SerializeField] Globals globals;

    public void AddScore()
    {
        score += globals.starPrice;

        scoreUI.text = score.ToString();
    }
}
