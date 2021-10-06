using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] Card cardPrefab;

    public void GenerateCard()
    {
        Instantiate(cardPrefab, this.transform);
    }
}
