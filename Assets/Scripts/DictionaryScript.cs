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
    // Info
    public Dictionary<string, string> textInfo = new Dictionary<string, string>(3);


    // Start is called before the first frame update
    void Awake()
    {
        // Settings
        settingsButton.Add("Ukr", "Вибери мову");
        settingsButton.Add("Rus", "Выбери язык");
        settingsButton.Add("Eng", "Language");
        // Menu
        buttonAR.Add("Ukr", "Грай із персонажами");
        buttonAR.Add("Rus", "Играй с персонажами");
        buttonAR.Add("Eng", "Play");

        buttonStories.Add("Ukr", "Бібліотека історій");
        buttonStories.Add("Rus", "Библиотека историй");
        buttonStories.Add("Eng", "Library");

        buttonQR.Add("Ukr", "Відскануй QR-код");
        buttonQR.Add("Rus", "Отсканируй QR-код");
        buttonQR.Add("Eng", "QR Code scanner");

        buttonStore.Add("Ukr", "Магазин");
        buttonStore.Add("Rus", "Магазин");
        buttonStore.Add("Eng", "Shop");
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

        buttons[0].Add("Ukr", "Літак");
        buttons[0].Add("Rus", "Самолёт");
        buttons[0].Add("Eng", "Airplane");
              
        buttons[1].Add("Ukr", "Ведмідь");
        buttons[1].Add("Rus", "Медведь");
        buttons[1].Add("Eng", "Bear");
              
        buttons[2].Add("Ukr", "Велосипед");
        buttons[2].Add("Rus", "Велосипед");
        buttons[2].Add("Eng", "Bicycle");
              
        buttons[3].Add("Ukr", "Автомобіль");
        buttons[3].Add("Rus", "Автомобиль");
        buttons[3].Add("Eng", "Car");
              
        buttons[4].Add("Ukr", "Кіт");
        buttons[4].Add("Rus", "Кот");
        buttons[4].Add("Eng", "Cat");
              
        buttons[5].Add("Ukr", "Лиc");
        buttons[5].Add("Rus", "Лис");
        buttons[5].Add("Eng", "Fox");
              
        buttons[6].Add("Ukr", "Заєць");
        buttons[6].Add("Rus", "Заяц");
        buttons[6].Add("Eng", "Hare");
              
        buttons[7].Add("Ukr", "Панда");
        buttons[7].Add("Rus", "Панда");
        buttons[7].Add("Eng", "Panda");
              
        buttons[8].Add("Ukr", "Гоночна машина");
        buttons[8].Add("Rus", "Гоночная машина");
        buttons[8].Add("Eng", "Racing Car");
              
        buttons[9].Add("Ukr", "Ракета");
        buttons[9].Add("Rus", "Ракета");
        buttons[9].Add("Eng", "Rocket");
              
        buttons[10].Add("Ukr", "Човник");
        buttons[10].Add("Rus", "Корабль");
        buttons[10].Add("Eng", "Ship");
              
        buttons[11].Add("Ukr", "Тигр");
        buttons[11].Add("Rus", "Тигр");
        buttons[11].Add("Eng", "Tiger");

        // QR
        textHint.Add("Ukr", "Відскануй QR-код");
        textHint.Add("Rus", "Отсканируй QR-код");
        textHint.Add("Eng", "QR Code scanner");

        textAsk.Add("Ukr", "Хочеш послухати казку про");
        textAsk.Add("Rus", "Хочешь послушать сказку про");
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

        qrStories[0].Add("Ukr", "Літак");
        qrStories[0].Add("Rus", "Самолёт");
        qrStories[0].Add("Eng", "Airplane");

        qrStories[1].Add("Ukr", "Велосіпед");
        qrStories[1].Add("Rus", "Велосипед");
        qrStories[1].Add("Eng", "Bicycle");

        qrStories[2].Add("Ukr", "Автомобіль");
        qrStories[2].Add("Rus", "Автомобиль");
        qrStories[2].Add("Eng", "Car");

        qrStories[3].Add("Ukr", "Кота і Лисиця");
        qrStories[3].Add("Rus", "Кота и Лиса");
        qrStories[3].Add("Eng", "Car and Fox");

        qrStories[4].Add("Ukr", "Лисиця i Ведмедя");
        qrStories[4].Add("Rus", "Лиса и Медведя");
        qrStories[4].Add("Eng", "Fox and Bear");

        qrStories[5].Add("Ukr", "Зайця, Панду і Ведмедя");
        qrStories[5].Add("Rus", "Зайца, Панду и Медведя");
        qrStories[5].Add("Eng", "Hare, Panda and Bear");

        qrStories[6].Add("Ukr", "Гоночну машину");
        qrStories[6].Add("Rus", "Гоночную машину");
        qrStories[6].Add("Eng", "Racing Car");

        qrStories[7].Add("Ukr", "Ракету");
        qrStories[7].Add("Rus", "Ракету");
        qrStories[7].Add("Eng", "Rocket");

        qrStories[8].Add("Ukr", "Човник");
        qrStories[8].Add("Rus", "Корабль");
        qrStories[8].Add("Eng", "Ship");

        qrStories[9].Add("Ukr", "Тигра і Зайця");
        qrStories[9].Add("Rus", "Тигра и Зайца");
        qrStories[9].Add("Eng", "Tiger and Hare");

        // Story Return
        buttonReturn.Add("Ukr", "Повернутися до списку");
        buttonReturn.Add("Rus", "Вернуться к списку");
        buttonReturn.Add("Eng", "Go back to the list");

        // AR
        textHintAR.Add("Ukr", "Наведи камеру на малюнок.");
        textHintAR.Add("Rus", "Наведи камеру на рисунок.");
        textHintAR.Add("Eng", "Point the camera at the picture.");

        textHintAR2.Add("Ukr", "Натисніть на картинку для включення звуку");
        textHintAR2.Add("Rus", "Нажми на объемную картинку для включения звука");
        textHintAR2.Add("Eng", "Click on the 3D image to turn on the sound");

        // Info
        textInfo.Add("Ukr", "КАЙКА - це чарівна дитяча постільна білизна та ковдри. " +
            "Наша продукція розповідає дітям казки. За допомогою додатку \"КАЙКА\" ви " +
            "зможете грати з персонажами на нашій продукції, сканувати qr-коди, а також " +
            "самостійно читати малюкові історії наших героїв.");
        textInfo.Add("Rus", "КАЙКА - это волшебное детское постельное белье и одеяла. " +
            "Наша продукция рассказывает детям сказки. С помощью приложения \"Кайка\" " +
            "вы сможете играть с персонажами на нашей продукции, сканировать qr-коды, а " +
            "также самостоятельно читать малышу истории наших героев.");
        textInfo.Add("Eng", "KAJKA is a magical baby bedding and blankets. Our products " +
            "tell fairy tales to children. With the \"KAIKA\" application, you can play with " +
            "the characters on our products, scan the QR code on the products and also " +
            "independently read the stories of our heroes to the kid.");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
