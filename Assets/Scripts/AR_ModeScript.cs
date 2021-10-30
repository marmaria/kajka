using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AR_ModeScript : MonoBehaviour
{
    [SerializeField] private GameObject panelMain;
    [SerializeField] private GameObject panelTop;
    [SerializeField] private GameObject panelAR;
    [SerializeField] private GameObject panelQR;

    [SerializeField] private AudioSource commonAudioSource;

    [SerializeField] private MenuControllerScript menuController;

    [SerializeField] private SettingsScript settingsScript;

    private bool _isARMode;
    public bool isARMode
    { get { return _isARMode; } }

    private bool _isQRMode;
    public bool isQRMode
    { get { return _isQRMode; } }

    private string currentStory;


    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartARMode()
    {
        _isARMode = true;
        menuController.CloseAll();
        panelMain.transform.GetComponent<Image>().enabled = false;
        panelTop.SetActive(false);
        panelAR.SetActive(true);
    }

    public void StopARMode()
    {
        commonAudioSource.Stop();
        _isARMode = false;
        panelTop.SetActive(true);
        panelMain.transform.GetComponent<Image>().enabled = true;
        ShowHint(true);
        panelAR.SetActive(false);
    }

    public void StartQR()
    {
        _isQRMode = true;
        menuController.CloseAll();
        panelMain.transform.GetComponent<Image>().enabled = false;
        panelTop.SetActive(false);
        panelQR.SetActive(true);
    }
    public void StopQR()
    {
        _isQRMode = false;
        panelTop.SetActive(true);
        panelMain.transform.GetComponent<Image>().enabled = true;
        panelQR.SetActive(false);
    }

    public void StopAll()
    {
        StopARMode();
        StopQR();
    }

    public void ShowHint(bool toShow)
    {
        panelAR.transform.Find("HintPanel").gameObject.SetActive(toShow);
    }

    public void ShowQRAskPanel(bool toShow, string StoryName = "")
    {
        currentStory = StoryName;

        panelQR.transform.Find("PanelAsk").gameObject.SetActive(toShow);
        panelQR.transform.Find("Text").gameObject.SetActive(!toShow);

        if (StoryName == "qr_Airplane")
        {
            ChangeQRStoryName(0);
        }
        else if (StoryName == "qr_Bicycle")
        {
            ChangeQRStoryName(1);
        }
        else if (StoryName == "qr_Car")
        {
            ChangeQRStoryName(2);
        }
        else if (StoryName == "qr_Cat_Fox")
        {
            ChangeQRStoryName(3);
        }
        else if (StoryName == "qr_Fox_Bear")
        {
            ChangeQRStoryName(4);
        }
        else if (StoryName == "qr_Hare_Panda_Bear")
        {
            ChangeQRStoryName(5);
        }
        else if (StoryName == "qr_Racing")
        {
            ChangeQRStoryName(6);
        }
        else if (StoryName == "qr_Rocket")
        {
            ChangeQRStoryName(7);
        }
        else if (StoryName == "qr_Ship")
        {
            ChangeQRStoryName(8);
        }
        else if (StoryName == "qr_Tiger_Hare")
        {
            ChangeQRStoryName(9);
        }

    }

    private void ChangeQRStoryName(int num)
    {
        panelQR.transform.Find("PanelAsk").Find("TextName").GetComponent<Text>().text = settingsScript.ChangeQRStory(num);
    }

    public void ClickQRYes()
    {
        if (currentStory == "qr_Airplane")
        {
            Application.OpenURL("https://happy.kajka.shop/5-1/");
        }
        else if (currentStory == "qr_Bicycle")
        {
            Application.OpenURL("https://happy.kajka.shop/5-9/");
        }
        else if (currentStory == "qr_Car")
        {
            Application.OpenURL("https://happy.kajka.shop/5-7/");
        }
        else if (currentStory == "qr_Cat_Fox")
        {
            Application.OpenURL("https://happy.kajka.shop/5-8/");
        }
        else if (currentStory == "qr_Fox_Bear")
        {
            Application.OpenURL("https://happy.kajka.shop/5-2/");
        }
        else if (currentStory == "qr_Hare_Panda_Bear")
        {
            Application.OpenURL("https://happy.kajka.shop/5-4/");
        }
        else if (currentStory == "qr_Racing")
        {
            Application.OpenURL("https://happy.kajka.shop/5-10/");
        }
        else if (currentStory == "qr_Rocket")
        {
            Application.OpenURL("https://happy.kajka.shop/5-3/");
        }
        else if (currentStory == "qr_Ship")
        {
            Application.OpenURL("https://happy.kajka.shop/5-5/");
        }
        else if (currentStory == "qr_Tiger_Hare")
        {
            Application.OpenURL("https://happy.kajka.shop/5-6/");
        }
    }
}
