using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] GameEvent swipeLeftEvent;
    [SerializeField] GameEvent swipeRightEvent;
    
    Vector2 dragStartPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragStartPosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (dragStartPosition.x >= eventData.position.x) swipeLeftEvent.Raise();
        else if (dragStartPosition.x < eventData.position.x) swipeRightEvent.Raise();
    }
}
