using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //Обработка свайпов
    
    [SerializeField] GameEvent swipeLeftEvent;
    [SerializeField] GameEvent swipeRightEvent;
    
    Vector2 dragStartPosition;

    
    //Запоминаем позицию на старте свайпа
    public void OnBeginDrag(PointerEventData eventData)
    {
        dragStartPosition = eventData.position;
    }

    //В течении свайпа ничего не происходит, но интерфейс необходимо реализовать, 
    //иначе система DragHandler не работает
    public void OnDrag(PointerEventData eventData)
    {
        
    }

    //Определяем направление свайпа по разнице координат начала и окончания свайпа
    //Запускаем соответствующее событие
    public void OnEndDrag(PointerEventData eventData)
    {
        if (dragStartPosition.x >= eventData.position.x) swipeLeftEvent.Raise();
        else if (dragStartPosition.x < eventData.position.x) swipeRightEvent.Raise();
    }
}
