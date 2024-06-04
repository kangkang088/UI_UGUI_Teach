using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scrollbar sb = this.GetComponent<Scrollbar>();
        print(sb.value);
        print(sb.size);
        sb.onValueChanged.AddListener(f => { print("代码控制，当前值" + f); });
    }
    public void ChangeValue(float v)
    {
        print("当前值" + v);
    }
}
