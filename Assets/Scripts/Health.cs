using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int health = 3;

    [SerializeField] Heart heartPrefab;
    [SerializeField] Globals globals;
    [SerializeField] Transform healthPanel;

    List<Heart> heartPool = new List<Heart>();

    private void Start()
    {
        GenerateHealthPanel();
    }

    public void ReduceHealth()
    {
        health--;


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
