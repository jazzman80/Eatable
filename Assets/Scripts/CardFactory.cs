using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] Card cardPrefab;

    bool active = true;

    private void Start()
    {
        GenerateCard();
    }

    public void GenerateCard()
    {
        if (active)
        {
            Card newCard = Instantiate(cardPrefab, this.transform);
            newCard.SetData(RandomCard());
        }
    }

    private Card.Quality RandomCard()
    {
        int random = Random.Range(0, 2);

        return (Card.Quality)random;
    }

    public void Activate()
    {
        active = true;
    }

    public void Deactivate()
    {
        active = false;
    }

}
