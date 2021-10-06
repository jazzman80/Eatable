using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int health;

    [SerializeField] Heart heartPrefab;
    [SerializeField] Globals globals;
    [SerializeField] Transform healthPanel;
    [SerializeField] GameEvent gameOver;

    List<Heart> heartPool = new List<Heart>();

    private void Start()
    {
        health = globals.initHealth;
        GenerateHealthPanel();
    }

    public void ReduceHealth()
    {
        health--;
        heartPool[health].Off();
        if (health == 0) gameOver.Raise();
    }

    private void GenerateHealthPanel()
    {
        for(int i = 0; i < globals.initHealth; i++)
        {
            Heart newHeart = Instantiate(heartPrefab, healthPanel);
            heartPool.Add(newHeart);
        }
    }
}
