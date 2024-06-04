using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Toggle toggle = this.GetComponent<Toggle>();
        toggle.isOn = false;
        toggle.onValueChanged.AddListener((a) => { print("代码监听状态改变:" + a); });

    }
    public void OnValueChange(bool isOn)
    {
        print("状态改变");
    }
}
