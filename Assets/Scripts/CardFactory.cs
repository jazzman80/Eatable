using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    //Фабрика карточек для игры

    [SerializeField] Card cardPrefab;
    [SerializeField] Globals globals;

    bool active = true;

    private void Start()
    {
        GenerateCard();
    }

    //Инстанциация новой карточки
    public void GenerateCard()
    {
        if (active)
        {
            Card newCard = Instantiate(cardPrefab, this.transform);

            //Передача папметров для установки данных на карточке
            newCard.SetData(RandomStuff());
        }
    }

    //Выбор случайной карточки из базы
    private Stuff RandomStuff()
    {
        int random = Random.Range(0, globals.stuff.Length);

        return globals.stuff[random];
    }

    //Активация фабрики при перезапуске игры
    public void Activate()
    {
        active = true;
    }

    //Отключение фабрики при окончании игры
    public void Deactivate()
    {
        active = false;
    }

}
