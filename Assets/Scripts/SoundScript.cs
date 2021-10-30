using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{

    private GameObject settingsController;

    //  private AudioClip clip;
    private AudioSource commonAudioSource;

    private bool IsSelected;
    public bool Selected
    {
        get
        {
            return this.IsSelected;
        }
        set
        {
            IsSelected = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        IsSelected = false;
        settingsController = GameObject.Find("SettingsController");
        commonAudioSource = GameObject.Find("Canvas").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClip()
    {
        //////////// копирование кода (StoriesScript)
     //   string PathText = panelSettings.GetComponent<SettingsScript>().TextPath;
        string PathAudio = settingsController.GetComponent<SettingsScript>().AudioPath;

     //   TextAsset textAsset;
        AudioClip audioClip;

     //   textAsset = Resources.Load<TextAsset>(PathText + name);
        audioClip = Resources.Load<AudioClip>(PathAudio + name);
        ///////////////////////

        commonAudioSource.PlayOneShot(audioClip);
    }

    public void StopClip()
    {
        commonAudioSource.Stop();
    }
}
