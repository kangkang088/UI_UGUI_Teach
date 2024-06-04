using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson16 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Dropdown dd = this.GetComponent<Dropdown>();
        print(dd.value);
        print(dd.options[dd.value].text);
        Sprite image = dd.options[dd.value].image;
    }
    public void ChangeValue(int index)
    {
        print("当前选项的索引值：" + index);
    }
}
