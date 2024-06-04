using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public static GamePanel panel;
    public Text textName;
    public Button btnChange;
    public Slider sliderSound;
    public Button btnAtk;
    public PlayerObj player;
    public Toggle togOn;
    public Toggle togOff;
    public ToggleGroup group;
    public Button btnBag;
    public Dropdown changeLight;
    public Light lights;
    public LongPress longPress;
    public GameObject imgRoot;
    public RectTransform imgFore;
    public RectTransform imgGyro;
    public EventTrigger eventTriggerGyro;

    private void Awake()
    {
        panel = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        changeLight.onValueChanged.AddListener((index) =>
        {
            switch (index)
            {
                case 0:
                    GetComponent<Light>().intensity = 1;
                    break;
                case 1:
                    GetComponent<Light>().intensity = 0.3f;
                    break;
            }
        });

        btnAtk.onClick.AddListener(() => { player.Fire(); });
        togOn.onValueChanged.AddListener(ChangeValue);
        //togOff.onValueChanged.AddListener(ChangeValue);
        btnChange.onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
            ChangeNamePanel.panel.gameObject.SetActive(true);
        });
        sliderSound.value = MusicData.volume;
        sliderSound.onValueChanged.AddListener(a =>
        {
            MusicData.volume = a;
        });
        btnBag.onClick.AddListener(() =>
        {
            BagPanel.panel.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        });
        imgRoot.gameObject.SetActive(false);
        longPress.upEvent += ButtonUp;
        longPress.downEvent += ButtonDown;

        //dragging
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.Drag;
        entry.callback.AddListener(GyroDrag);
        eventTriggerGyro.triggers.Add(entry);

        //drag end...
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.EndDrag;
        entry.callback.AddListener(EndGyroDrag);
        eventTriggerGyro.triggers.Add(entry);
    }
    void ChangeValue(bool v)
    {
        foreach (Toggle item in group.ActiveToggles())
        {
            if (item == togOn)
            {
                MusicData.soundIsOpen = true;
            }
            else if (item == togOff)
            {
                MusicData.soundIsOpen = false;
            }
        }
    }
    private bool isDown = false;
    private float time = 0;
    public float growSpeed = 10;
    private float HP = 50;
    private void Update()
    {
        if (isDown)
        {
            time += Time.deltaTime;
            if (time >= 0.2f)
            {
                imgRoot.gameObject.SetActive(true);
                imgFore.sizeDelta += new Vector2(growSpeed * Time.deltaTime, 0);
                if (imgFore.sizeDelta.x >= 800)
                {
                    HP += 10;
                    imgFore.sizeDelta = new Vector2(0, 40);
                    print("当前HP：" + HP);
                }
            }
        }
        print(imgGyro.anchoredPosition);
    }
    void ButtonDown()
    {
        time = 0;
        isDown = true;
        imgFore.sizeDelta = new Vector2(0, 40);
    }
    void ButtonUp()
    {
        isDown = false;
        imgRoot.gameObject.SetActive(false);
    }

    void GyroDrag(BaseEventData data)
    {
        PointerEventData pointerEventData = data as PointerEventData;
        //imgGyro.position += new Vector3(pointerEventData.delta.x, pointerEventData.delta.y, 0);

        Vector2 nowPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(imgGyro.parent as RectTransform, pointerEventData.position, pointerEventData.enterEventCamera, out nowPos);
        imgGyro.localPosition = nowPos;

        if (imgGyro.anchoredPosition.magnitude > 120)
        {
            imgGyro.anchoredPosition = imgGyro.anchoredPosition.normalized * 120;
        }
        player.MoveGyro(imgGyro.anchoredPosition);
    }
    void EndGyroDrag(BaseEventData data)
    {
        imgGyro.anchoredPosition = Vector2.zero;
        player.MoveGyro(Vector2.zero);
    }
}
