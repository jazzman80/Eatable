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
        Card newCard = Instantiate(cardPrefab, this.transform);
        newCard.SetData(RandomCard());
    }

    private Card.Quality RandomCard()
    {
        int random = Random.Range(0, 2);

        return (Card.Quality)random;
    }
}
