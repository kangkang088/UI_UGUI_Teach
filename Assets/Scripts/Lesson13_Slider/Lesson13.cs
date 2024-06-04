using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Slider slider = this.GetComponent<Slider>();
        slider.maxValue = 1;
        slider.minValue = 0;
        //slider.wholeNumbers = true;
        
        print(slider.value);
        slider.onValueChanged.AddListener(a => { print("代码控制，当前柄所在的值：" + a); });
    }
    public void ChangeValue(float value)
    {
        print("当前柄所在的值：" + value);
    }
}
