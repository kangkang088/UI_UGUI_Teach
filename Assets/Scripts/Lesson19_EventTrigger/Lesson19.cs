using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson19 : MonoBehaviour
{
    public EventTrigger eventTrigger;
    // Start is called before the first frame update
    void Start()
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener((data) => 
        {
            print("抬起");
        });
        eventTrigger.triggers.Add(entry);
    }
    
}
