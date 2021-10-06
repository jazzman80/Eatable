using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreUI;
    [SerializeField] Globals globals;

    public void AddScore()
    {
        score += globals.starPrice;
        scoreUI.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreUI.text = score.ToString();
    }
}
