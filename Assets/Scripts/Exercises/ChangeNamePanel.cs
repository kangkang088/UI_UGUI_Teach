using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNamePanel : MonoBehaviour
{
    public static ChangeNamePanel panel;
    private void Awake()
    {
        panel = this;
        this.gameObject.SetActive(false);
    }
    public InputField inputName;
    public Button btnSure;
    // Start is called before the first frame update
    void Start()
    {
        btnSure.onClick.AddListener(() => {
            GamePanel.panel.textName.text = inputName.text;
            this.gameObject.SetActive(false);
            GamePanel.panel.gameObject.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
