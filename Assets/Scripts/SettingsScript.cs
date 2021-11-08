using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    private string _audioPath;
    private string _textPath;

    [SerializeField] DictionaryScript dictionaryScript;
    [SerializeField] GameObject panelMenu;
    [SerializeField] GameObject panelStories;
    [SerializeField] GameObject panelOpenStory;
    [SerializeField] GameObject panelSettings;
    [SerializeField] GameObject panelQR;
    [SerializeField] GameObject panelAR;
    [SerializeField] GameObject panelInfo;

    private string currentLang;

    public string AudioPath
    {
        get { return _audioPath; }
    }

    public string TextPath
    {
        get { return _textPath; }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentLang = "Ukr";

        ChangeLanguage(currentLang);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeLanguage(string lang)
    {
        _textPath = "Texts\\" + lang.ToString() + "\\";
        _audioPath = "Audio\\" + lang.ToString() + "\\";

        currentLang = lang;

        ChangePanelSettings();
        ChangePanelMenu();
        ChangePanelStories();
        ChangePanelQR();
        ChangePanelAR();
        ChangePanelInfo();
    }

    private void ChangePanelSettings()
    {
        panelSettings.transform.Find("Text").GetComponent<Text>().text = dictionaryScript.settingsButton[currentLang];
    }

    private void ChangePanelMenu()
    {
        panelMenu.transform.Find("ButtonAR").Find("Text").GetComponent<Text>().text = dictionaryScript.buttonAR[currentLang];
        panelMenu.transform.Find("ButtonStories").Find("Text").GetComponent<Text>().text = dictionaryScript.buttonStories[currentLang];
        panelMenu.transform.Find("ButtonQR").Find("Text").GetComponent<Text>().text = dictionaryScript.buttonQR[currentLang];
        panelMenu.transform.Find("ButtonStore").Find("Text").GetComponent<Text>().text = dictionaryScript.buttonStore[currentLang];
    }

    private void ChangePanelStories()
    {
        panelStories.transform.Find("Button0").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[0][currentLang];
        panelStories.transform.Find("Button1").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[1][currentLang];
        panelStories.transform.Find("Button2").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[2][currentLang];
        panelStories.transform.Find("Button3").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[3][currentLang];
        panelStories.transform.Find("Button4").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[4][currentLang];
        panelStories.transform.Find("Button5").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[5][currentLang];
        panelStories.transform.Find("Button6").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[6][currentLang];
        panelStories.transform.Find("Button7").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[7][currentLang];
        panelStories.transform.Find("Button8").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[8][currentLang];
        panelStories.transform.Find("Button9").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[9][currentLang];
        panelStories.transform.Find("Button10").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[10][currentLang];
        panelStories.transform.Find("Button11").Find("Text").GetComponent<Text>().text = dictionaryScript.buttons[11][currentLang];

        panelOpenStory.transform.Find("Button").Find("Text").GetComponent<Text>().text = dictionaryScript.buttonReturn[currentLang];
    }

    private void ChangePanelQR()
    {
        panelQR.transform.Find("Text").GetComponent<Text>().text = dictionaryScript.textHint[currentLang];
        panelQR.transform.Find("PanelAsk").Find("Text").GetComponent<Text>().text = dictionaryScript.textAsk[currentLang];
    }

    private void ChangePanelAR()
    {
        panelAR.transform.Find("HintPanel").Find("Text").GetComponent<Text>().text = dictionaryScript.textHintAR[currentLang];
        panelAR.transform.Find("HintPanel").Find("Text2").GetComponent<Text>().text = dictionaryScript.textHintAR2[currentLang];
    }

    private void ChangePanelInfo()
    {
        panelInfo.transform.Find("Text").GetComponent<Text>().text = dictionaryScript.textInfo[currentLang];
    }

    public string ChangePanelOpenStory(int num, string lang = "")
    {
        string story_name;

        if (lang != "")
        {
            story_name = dictionaryScript.buttons[num][lang];
        }
        else
        {
            story_name = dictionaryScript.buttons[num][currentLang];
        }

        return story_name;
    }

    public string ChangeQRStory(int num)
    {
        string story_name;

        story_name = dictionaryScript.qrStories[num][currentLang];

        return story_name;
    }

}