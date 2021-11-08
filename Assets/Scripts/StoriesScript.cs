using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoriesScript : MonoBehaviour
{
    [SerializeField] private GameObject panelStories;
    [SerializeField] private GameObject panelOneStory;
    [SerializeField] private SettingsScript settingsScript;
    [SerializeField] private AudioSource commonAudioSource;

    private AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartStories()
    {
        StopAll();
        panelStories.SetActive(true);
    }

    public void OpenOne(int num)
    {
        panelStories.SetActive(false);
        panelOneStory.SetActive(true);

        ChoiceStory(num);
    }

    public void StopAll()
    {
        StopAudio();
        panelStories.SetActive(false);
        panelOneStory.SetActive(false);
    }

    private void ChoiceStory(int num)
    {
        panelOneStory.transform.Find("TextName").GetComponent<Text>().text = settingsScript.ChangePanelOpenStory(num);
        string story_name = settingsScript.ChangePanelOpenStory(num, "Eng");

        string PathText = settingsScript.TextPath;
        string PathAudio = settingsScript.AudioPath;

        TextAsset textAsset;
        if (textAsset = Resources.Load<TextAsset>(PathText + story_name))
        {
            panelOneStory.transform.Find("Scroll View").Find("Viewport").Find("Content").Find("Text").GetComponent<Text>().text = textAsset.text;
        }

        audioClip = Resources.Load<AudioClip>(PathAudio + story_name);
        commonAudioSource.clip = audioClip;
    }

    public void PlayAudio()
    {
        commonAudioSource.Play();
        panelOneStory.transform.Find("Panel").Find("Play").gameObject.SetActive(false);
        panelOneStory.transform.Find("Panel").Find("Pause").gameObject.SetActive(true);
    }
    public void PauseAudio()
    {
        commonAudioSource.Pause();
        panelOneStory.transform.Find("Panel").Find("Play").gameObject.SetActive(true);
        panelOneStory.transform.Find("Panel").Find("Pause").gameObject.SetActive(false);
    }
    public void StopAudio()
    {
        commonAudioSource.Stop();
        panelOneStory.transform.Find("Panel").Find("Play").gameObject.SetActive(true);
        panelOneStory.transform.Find("Panel").Find("Pause").gameObject.SetActive(false);
    }
    public void RepeatAudio()
    {
        commonAudioSource.Stop();
        PlayAudio();
    }
}
