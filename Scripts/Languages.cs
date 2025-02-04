using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Languages : MonoBehaviour
{
 

    #region GameObjects
    public GameObject languagePanel;
    public GameObject menuPanel;
    public GameObject scripts;
    public GameObject aptPanel;
    #endregion


    #region Texts
    public TextMeshProUGUI virivkaText;
    public TextMeshProUGUI saunaText;
    public TextMeshProUGUI linkText;
    public TextMeshProUGUI virpopisText;
    public TextMeshProUGUI saunpopisText;
    public TextMeshProUGUI payText;
    public TextMeshProUGUI wifiText;
    public TextMeshProUGUI grillText;
    public TextMeshProUGUI kavaText;
    public TextMeshProUGUI koloText;
    public TextMeshProUGUI guestCardText;
    public TextMeshProUGUI pyroText;
    public TextMeshProUGUI snidaneText;
    public TextMeshProUGUI svickyText;
    public TextMeshProUGUI alergenText;
    #endregion

    #region Bools
    public bool mIsOn = false;

    public static bool isCzech = false;
    public static bool isEnglish = false;
    public static bool isGerman = false;


    private static Dictionary<string, bool[]> languages = new Dictionary<string, bool[]>()
    {
        {"language", new bool[] {isCzech, isEnglish, isGerman} }
    };

    #endregion

    #region CurrentTexts
    public static string currentLink;
    public string currentVirivka;
    public string currentSauna;
    public string currentObèerstvení;
    public string currentVirText;
    public string currentSaunText;

    public string currentPay;
    public string currentWifi;
    public string currentGrill;
    public string currentKava;
    public string currentKolo;
    public string currentGuestCard;
    public string currentPyro;
    public string currentSnidane;
    public string currentSvicky;
    public string currentAlergen;

    #endregion

    #region Czech
    public string czLink;
    public string czVirivka;
    public string czSauna;
    public string czObèerstvení;
    public static string czVirText;
    public static string czSaunText;
    #endregion



    public static int globalLang;



    public string czPay;
    public string enPay;
    public string dePay;

    public string czWifi;
    public string enWifi;
    public string deWifi;

    public string czGrill;
    public string enGrill;
    public string deGrill;

    public string czKava;
    public string enKava;
    public string deKava;

    public string czKolo;
    public string enKolo;
    public string deKolo;

    public string czGuestCard;
    public string enGuestCard;
    public string deGuestCard;

    public string czPyro;
    public string enPyro;
    public string dePyro;

    public string czSnidane;
    public string enSnidane;
    public string deSnidane;

    public string czSvicky;
    public string enSvicky;
    public string deSvicky;

    public string czAlergen;
    public string enAlergen;
    public string deAlergen;

    #region English
    public string enLink;
    public string enWhirlpool;
    public string enSauna;
    public string enFoodOrders;
    public static string enWhirText;
    public static string enSaunText;
    #endregion

    #region Deutsh
    public string deLink;
    public string deWhirlpool;
    public string deSauna;
    public string deEssenBestellen;
    public static string deWhirText;
    public static string deSaunText;
    #endregion

    public GameObject virivkaPanel;
    void Start()
    {
        czVirivka = "Víøivka";
        czSauna = "Sauna";
        czObèerstvení = "Menu";
        czLink = "https://www.youandme.cz/food/cs/";
        czPay = "Platba";
        enPay = "Payment";
        dePay = "Zahlung";

        czWifi = "WiFi";
        enWifi = "WiFi";
        deWifi = "WiFi";

        czGrill = "Grilování";
        enGrill = "Grilling";
        deGrill = "Grillen";

        czKava = "Kávovar";
        enKava = "Coffee machine";
        deKava = "Kaffeemaschine";

        czKolo = "Pùjèení kola";
        enKolo = "Bike Rental";
        deKolo = "Fahrradverleih";

        czGuestCard = "Karta Hosta";
        enGuestCard = "Guest Card";
        deGuestCard = "Gästekarte";

        czPyro = "Pyrotechnika";
        enPyro = "Fireworks";
        dePyro = "Feuerwerk";

        czSnidane = "Snídanì";
        enSnidane = "Breakfast";
        deSnidane = "Frühstück";

        czSvicky = "Svíèky";
        enSvicky = "Candles";
        deSvicky = "Kerzen";

        enWhirlpool = "Whirlpool";
        enSauna = "Sauna";
        enFoodOrders = "Menu";
        enLink = "https://www.youandme.cz/food/en/";

        deWhirlpool = "Whirlpool";
        deSauna = "Sauna";
        deEssenBestellen = "Menü";
        deLink = "https://www.youandme.cz/food/de/";

        czAlergen = "Alergeny";
        enAlergen = "Alergens";
        deAlergen = "Allergene";

        currentVirivka = czVirivka;
        currentSauna = czSauna;
        currentObèerstvení = czObèerstvení;
        currentLink = czLink;
        currentPay = czPay;
        currentWifi = czWifi;
        currentGrill = czGrill;
        currentKava = czKava;
        currentKolo = czKolo;
        currentGuestCard = czGuestCard;
        currentPyro = czPyro;
        currentSnidane = czSnidane;
        currentSvicky = czSvicky;
        currentAlergen = czAlergen;

    }

        private void Update()
        {
            mIsOn = Buttons.mIsOn;
            virivkaText.text = currentVirivka;
            saunaText.text = currentSauna;
            linkText.text = currentObèerstvení;
        payText.text = currentPay;
        wifiText.text = currentWifi;
        grillText.text = currentGrill;
        kavaText.text = currentKava;
        koloText.text = currentKolo;
        guestCardText.text = currentGuestCard;
        pyroText.text = currentPyro;
        snidaneText.text = currentSnidane;
        svickyText.text = currentSvicky;
        alergenText.text = currentAlergen;



    }
    public void Czech()
    {

        isCzech = true;
        isEnglish = false;
        isGerman = false;
        globalLang = 0;
        Toggles1.aptBool = false;
        aptPanel.SetActive(false);

        currentVirivka = czVirivka;
        currentSauna = czSauna;
        currentObèerstvení = czObèerstvení;
        currentLink = czLink;
        currentPay = czPay;
        currentWifi = czWifi;
        currentGrill = czGrill;
        currentKava = czKava;
        currentKolo = czKolo;
        currentGuestCard = czGuestCard;
        currentPyro = czPyro;
        currentSnidane = czSnidane;
        currentSvicky = czSvicky;
        currentAlergen = czAlergen;

        languagePanel.GetComponent<Animation>().Play("langSlideAnim");


    }

    public void English()
    {
        isCzech = false;
        isEnglish = true;
        isGerman = false;
        globalLang = 1;
        Toggles1.aptBool = false;
        aptPanel.SetActive(false);

        currentVirivka = enWhirlpool;
        currentSauna = enSauna;
        currentObèerstvení = enFoodOrders;
        currentLink = enLink;
        currentVirText = enWhirText;
        currentSaunText = enSaunText;
        currentVirivka = enWhirlpool;
        currentSauna = enSauna;
        currentPay = enPay;
        currentWifi = enWifi;
        currentGrill = enGrill;
        currentKava = enKava;
        currentKolo = enKolo;
        currentGuestCard = enGuestCard;
        currentPyro = enPyro;
        currentSnidane = enSnidane;
        currentSvicky = enSvicky;
        currentAlergen = enAlergen;
    languagePanel.GetComponent<Animation>().Play("langSlideAnim");



    }

    public void German()
    {
        isCzech = false;
        isEnglish = false;
        isGerman = true;
        globalLang = 2;
        Toggles1.aptBool = false;
        aptPanel.SetActive(false);

        currentVirivka = deWhirlpool;
        currentSauna = deSauna;
        currentObèerstvení = deEssenBestellen;
        currentLink = deLink;
        currentVirText= deWhirText;
        currentSaunText = deSaunText;
        currentPay = dePay;
        currentWifi = deWifi;
        currentGrill = deGrill;
        currentKava = deKava;
        currentKolo = deKolo;
        currentGuestCard = deGuestCard;
        currentPyro = dePyro;
        currentSnidane = deSnidane;
        currentSvicky = deSvicky;
        currentAlergen = deAlergen;

    languagePanel.GetComponent<Animation>().Play("langSlideAnim");



    }

    public void BackButton()
    {
        scripts.GetComponent<Buttons>().ButtonClose();
        scripts.GetComponent<Buttons>().ButtonClose();

        languagePanel.GetComponent<Animation>().Play("langSlideRevAnim");
        if (mIsOn)
        {
        menuPanel.GetComponent<Animation>().Play("menuAnimRev");
        testttt.mIsOn = false;
        }

    }
}
