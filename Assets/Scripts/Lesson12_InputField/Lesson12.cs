using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputField input = this.GetComponent<InputField>();
        
        input.contentType = InputField.ContentType.Standard;
        input.text = "hello";

        print(input.text);

        input.onValueChanged.AddListener(str => { print("代码监听，改变后的内容：" + str); });
        input.onEndEdit.AddListener(str => { print("代码监听，结束后的内容：" + str); });
    }
    public void ChangeInput(string str)
    {
        print("改变后的内容：" + str);
    }
    public void EndEdit(string str)
    {
        print("结束时的内容" + str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
