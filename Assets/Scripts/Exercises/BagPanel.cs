using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagPanel : MonoBehaviour
{
    public static BagPanel panel;
    public ScrollRect svItems;
    public Button btnQuit;
    private void Awake()
    {
        panel = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        btnQuit.onClick.AddListener(() => 
        {
            GamePanel.panel.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        });
        this.gameObject.SetActive(false);
        for (int i = 0; i < 30; i++)
        {
            GameObject item = Instantiate(Resources.Load<GameObject>("Item"));
            item.transform.SetParent(svItems.content,false);
            item.transform.localPosition = new Vector3(10, -10, 0) + new Vector3(190 * (i % 4), -170 * (i / 4), 0);
        }
        svItems.content.sizeDelta = new Vector2(0, Mathf.CeilToInt(30 / 4f) * 170);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
