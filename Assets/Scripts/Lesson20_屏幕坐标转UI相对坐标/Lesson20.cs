using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson20 : MonoBehaviour,IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 nowPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(this.transform.parent as RectTransform, eventData.position, eventData.enterEventCamera, out nowPos);
        this.transform.localPosition = nowPos;
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
