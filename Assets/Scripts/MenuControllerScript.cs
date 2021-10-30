using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerScript : MonoBehaviour
{
    [SerializeField] private AR_ModeScript AR_Mode;
    [SerializeField] private StoriesScript Stories_Controller;
    [SerializeField] private GameObject panelHome;
    [SerializeField] private GameObject panelInfo;
    [SerializeField] private GameObject panelSettings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMenu()
    {
        CloseAll();
        AR_Mode.StopAll();
        //AR_Mode.StopAll();
        //panelInfo.SetActive(false);
        //panelSettings.SetActive(false);
        panelHome.SetActive(true);
    }

    public void OpenSettings()
    {
        CloseAll();
        AR_Mode.StopAll();
        //AR_Mode.StopAll();
        //panelHome.SetActive(false);
        //panelInfo.SetActive(false);
        panelSettings.SetActive(true);
    }

    public void OpenInfo()
    {
        CloseAll();
        AR_Mode.StopAll();
        //AR_Mode.StopAll();
        //panelHome.SetActive(false);
        //panelSettings.SetActive(false);
        panelInfo.SetActive(true);
    }

    public void CloseAll()
    {
        Stories_Controller.StopAll();
        //AR_Mode.StopAll();
        panelHome.SetActive(false);
        panelSettings.SetActive(false);
        panelInfo.SetActive(false);
    }
}
