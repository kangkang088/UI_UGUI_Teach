using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson18 : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler,IPointerDownHandler,IPointerUpHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        print("鼠标（触碰）点击对象");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print("鼠标（触碰）指针按下");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("鼠标指针进入对象");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("鼠标指针离开对象");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("鼠标（触碰）抬起");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
