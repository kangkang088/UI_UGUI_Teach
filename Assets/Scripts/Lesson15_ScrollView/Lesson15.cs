using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScrollRect scrollRect = this.GetComponent<ScrollRect>();
        //scrollRect.content.sizeDelta = new Vector2(200, 200);
        scrollRect.normalizedPosition = new Vector2(0, 0.5f);
    }
    public void ChangedValue(Vector2 v)
    {
        print("当前content的位置" + v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
