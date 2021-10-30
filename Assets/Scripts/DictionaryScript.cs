using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryScript : MonoBehaviour
{
    // Settings
    public Dictionary<string, string> settingsButton = new Dictionary<string, string>(3);
    // Menu
    public Dictionary<string, string> buttonAR = new Dictionary<string, string>(3);
    public Dictionary<string, string> buttonStories = new Dictionary<string, string>(3);
    public Dictionary<string, string> buttonQR = new Dictionary<string, string>(3);
    public Dictionary<string, string> buttonStore = new Dictionary<string, string>(3);
    // Stories
    public Dictionary<string, string>[] buttons = new Dictionary<string, string>[12];
    // QR
    public Dictionary<string, string> textHint = new Dictionary<string, string>(3);
    public Dictionary<string, string> textAsk = new Dictionary<string, string>(3);
    // QR Stories
    public Dictionary<string, string>[] qrStories = new Dictionary<string, string>[12];
    // Story Return
    public Dictionary<string, string> buttonReturn = new Dictionary<string, string>(3);
    // AR
    public Dictionary<string, string> textHintAR = new Dictionary<string, string>(3);
    public Dictionary<string, string> textHintAR2 = new Dictionary<string, string>(3);


    // Start is called before the first frame update
    void Awake()
    {
        // Settings
        settingsButton.Add("Ukr", "������ ����");
        settingsButton.Add("Rus", "������ ����");
        settingsButton.Add("Eng", "Choose a language");
        // Menu
        buttonAR.Add("Ukr", "���� � �����������");
        buttonAR.Add("Rus", "����� � �����������");
        buttonAR.Add("Eng", "Play with characters");

        buttonStories.Add("Ukr", "��������� ������");
        buttonStories.Add("Rus", "���������� �������");
        buttonStories.Add("Eng", "Library of Stories");

        buttonQR.Add("Ukr", "³������� QR-���");
        buttonQR.Add("Rus", "���������� QR-���");
        buttonQR.Add("Eng", "Scan the QR code");

        buttonStore.Add("Ukr", "�������");
        buttonStore.Add("Rus", "�������");
        buttonStore.Add("Eng", "Store");
        // Stories
        buttons[0] = new Dictionary<string, string>(3);
        buttons[1] = new Dictionary<string, string>(3);
        buttons[2] = new Dictionary<string, string>(3);
        buttons[3] = new Dictionary<string, string>(3);
        buttons[4] = new Dictionary<string, string>(3);
        buttons[5] = new Dictionary<string, string>(3);
        buttons[6] = new Dictionary<string, string>(3);
        buttons[7] = new Dictionary<string, string>(3);
        buttons[8] = new Dictionary<string, string>(3);
        buttons[9] = new Dictionary<string, string>(3);
        buttons[10] = new Dictionary<string, string>(3);
        buttons[11] = new Dictionary<string, string>(3);

        buttons[0].Add("Ukr", "˳���");
        buttons[0].Add("Rus", "������");
        buttons[0].Add("Eng", "Airplane");
              
        buttons[1].Add("Ukr", "������");
        buttons[1].Add("Rus", "�������");
        buttons[1].Add("Eng", "Bear");
              
        buttons[2].Add("Ukr", "��������");
        buttons[2].Add("Rus", "���������");
        buttons[2].Add("Eng", "Bicycle");
              
        buttons[3].Add("Ukr", "���������");
        buttons[3].Add("Rus", "����������");
        buttons[3].Add("Eng", "Car");
              
        buttons[4].Add("Ukr", "ʳ�");
        buttons[4].Add("Rus", "���");
        buttons[4].Add("Eng", "Cat");
              
        buttons[5].Add("Ukr", "˳c");
        buttons[5].Add("Rus", "���");
        buttons[5].Add("Eng", "Fox");
              
        buttons[6].Add("Ukr", "�����");
        buttons[6].Add("Rus", "����");
        buttons[6].Add("Eng", "Hare");
              
        buttons[7].Add("Ukr", "�����");
        buttons[7].Add("Rus", "�����");
        buttons[7].Add("Eng", "Panda");
              
        buttons[8].Add("Ukr", "������� ������");
        buttons[8].Add("Rus", "�������� ������");
        buttons[8].Add("Eng", "Racing Car");
              
        buttons[9].Add("Ukr", "������");
        buttons[9].Add("Rus", "������");
        buttons[9].Add("Eng", "Rocket");
              
        buttons[10].Add("Ukr", "������");
        buttons[10].Add("Rus", "�������");
        buttons[10].Add("Eng", "Ship");
              
        buttons[11].Add("Ukr", "����");
        buttons[11].Add("Rus", "����");
        buttons[11].Add("Eng", "Tiger");

        // QR
        textHint.Add("Ukr", "³������� QR-���");
        textHint.Add("Rus", "���������� QR-���");
        textHint.Add("Eng", "Scan the QR code");

        textAsk.Add("Ukr", "����� ��������� ����� ���");
        textAsk.Add("Rus", "������ ��������� ������ ���");
        textAsk.Add("Eng", "Do you want to hear a story about");

        // QR Stories
        qrStories[0] = new Dictionary<string, string>(3);
        qrStories[1] = new Dictionary<string, string>(3);
        qrStories[2] = new Dictionary<string, string>(3);
        qrStories[3] = new Dictionary<string, string>(3);
        qrStories[4] = new Dictionary<string, string>(3);
        qrStories[5] = new Dictionary<string, string>(3);
        qrStories[6] = new Dictionary<string, string>(3);
        qrStories[7] = new Dictionary<string, string>(3);
        qrStories[8] = new Dictionary<string, string>(3);
        qrStories[9] = new Dictionary<string, string>(3);

        qrStories[0].Add("Ukr", "˳���");
        qrStories[0].Add("Rus", "������");
        qrStories[0].Add("Eng", "Airplane");

        qrStories[1].Add("Ukr", "��������");
        qrStories[1].Add("Rus", "���������");
        qrStories[1].Add("Eng", "Bicycle");

        qrStories[2].Add("Ukr", "���������");
        qrStories[2].Add("Rus", "����������");
        qrStories[2].Add("Eng", "Car");

        qrStories[3].Add("Ukr", "���� � ������");
        qrStories[3].Add("Rus", "���� � ����");
        qrStories[3].Add("Eng", "Car and Fox");

        qrStories[4].Add("Ukr", "������ i �������");
        qrStories[4].Add("Rus", "���� � �������");
        qrStories[4].Add("Eng", "Fox and Bear");

        qrStories[5].Add("Ukr", "�����, ����� � �������");
        qrStories[5].Add("Rus", "�����, ����� � �������");
        qrStories[5].Add("Eng", "Hare, Panda and Bear");

        qrStories[6].Add("Ukr", "������� ������");
        qrStories[6].Add("Rus", "�������� ������");
        qrStories[6].Add("Eng", "Racing Car");

        qrStories[7].Add("Ukr", "������");
        qrStories[7].Add("Rus", "������");
        qrStories[7].Add("Eng", "Rocket");

        qrStories[8].Add("Ukr", "������");
        qrStories[8].Add("Rus", "�������");
        qrStories[8].Add("Eng", "Ship");

        qrStories[9].Add("Ukr", "����� � �����");
        qrStories[9].Add("Rus", "����� � �����");
        qrStories[9].Add("Eng", "Tiger and Hare");

        // Story Return
        buttonReturn.Add("Ukr", "����������� �� ������");
        buttonReturn.Add("Rus", "��������� � ������");
        buttonReturn.Add("Eng", "Go back to the list");

        // AR
        textHintAR.Add("Ukr", "������ �� �������");
        textHintAR.Add("Rus", "������ �� �������");
        textHintAR.Add("Eng", "Hover over the drawing");

        textHintAR2.Add("Ukr", "������� �� ��'���� �������� ��� ��������� �����");
        textHintAR2.Add("Rus", "����� �� �������� �������� ��� ��������� �����");
        textHintAR2.Add("Eng", "Click on the surround image to turn on the sound");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
