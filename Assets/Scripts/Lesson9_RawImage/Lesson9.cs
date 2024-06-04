using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RawImage rawImage = this.GetComponent<RawImage>();
        rawImage.texture = Resources.Load<Texture>("ui_TY_fanhui_01");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
