using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LongPress : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public event UnityAction upEvent;
    public event UnityAction downEvent;
    public void OnPointerDown(PointerEventData eventData)
    {
        downEvent?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        upEvent?.Invoke();
    }
}
