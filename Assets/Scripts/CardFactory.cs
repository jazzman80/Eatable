using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] Globals globals;

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
            newCard.SetData(RandomStuff());
        }
    }

    private Stuff RandomStuff()
    {
        int random = Random.Range(0, globals.stuff.Length);

        return globals.stuff[random];
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
