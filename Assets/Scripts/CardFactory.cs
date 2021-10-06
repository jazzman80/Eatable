using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] Card cardPrefab;

    private void Start()
    {
        GenerateCard();
    }

    public void GenerateCard()
    {
        Instantiate(cardPrefab, this.transform);
    }
}
