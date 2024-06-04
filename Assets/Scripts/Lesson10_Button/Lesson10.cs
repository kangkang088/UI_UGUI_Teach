using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = this.GetComponent<Button>();
        button.interactable = true;
        button.transition = Selectable.Transition.ColorTint;

        Image img = this.GetComponent<Image>();

        button.onClick.AddListener(ClickButton2);

    }
    public void ClickButton()
    {
        print("按钮点击!");
    }
    private void ClickButton2()
    {
        print("private按钮点击!");
        
    }
   
}
