using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Toggles1 : MonoBehaviour
{
    public GameObject saunaPanel;
    public GameObject menuPanel;
    public static bool saunaBool;
    public TMP_Text saunaText;

    public ToggleGroup saunaToggleGroup;

    public Toggle bioSauna;
    public Toggle finParaSauna;
    public Toggle finSauna;
    public Toggle tropSauna;
    public Toggle saltSauna;
    public Toggle stoneSauna;

    public string currentText;

 // Reference to the TMP_Text component

    public static string czFinParaSaunaText = ("Tato varianta finské sauny je vybavena zaøízením, které v pravidelnıch intervalech polévá rozpálené kameny na kamnech vodou a horkı vzduch pak rozfouká po saunì.\r\nKadıch pár minut tak vaše tìlo zasáhne intenzivní tepelná vlna, která zvıší vaše vnímání pocitového tepla.\r\nSauna vám pomùe vyplavit z tìla toxiny, prokrvit orgány i kùi, posílit imunitu a zbavit se stresu.\r\nTeplota se v klasické finské saunì pohybuje v rozmezí od 85 do 95 stupòù Celsia. Vlhkost vzduchu je pak mezi 10 a 20 procenty. ");
    public static string enFinParaSaunaText = ("This variation of the Finnish sauna is equipped with a device that regularly pours water over the hot stones on the stove, creating a burst of steam that is circulated throughout the sauna.\n\rEvery few minutes, your body will experience an intense wave of heat, enhancing your perception of warmth.\n\rThe sauna helps eliminate toxins from your body, improves blood circulation to organs and skin, boosts immunity, and helps reduce stress.\n\rThe temperature in a traditional Finnish sauna ranges from 85 to 95 degrees Celsius. The humidity level is typically between 10 and 20 percent.");
    public static string deFinParaSaunaText = ("Diese Variante der finnischen Sauna ist mit einer Vorrichtung ausgestattet, die in regelmäßigen Abständen Wasser über die heißen Steine auf dem Ofen gießt und so einen Dampfstoß erzeugt, der sich in der gesamten Sauna verteilt. Alle paar Minuten wird Ihr Körper von einer intensiven Hitzewelle erfasst, was Ihre Wahrnehmung von Wärme verstärkt. Die Sauna hilft dabei, Giftsto?e aus Ihrem Körper auszuschwemmen, verbessert die Durchblutung von Organen und Haut, stärkt das Immunsystem und hilft beim Stressabbau. Die Temperatur in einer klassischen finnischen Sauna liegt zwischen 85 und 95 Grad Celsius. Die Luftfeuchtigkeit beträgt normalerweise zwischen 10 und 20 Prozent. ");

    public static string czBioSaunaText = ("Mezi pomìrnì nové druhy saun patøí biosauny.\n\rJejich specifikum spoèívá v tom, e jsou vytápìny kamny s vıparníkem, které uvnitø sauny dokáou udrovat stálou teplotu (kolem 60 stupòù Celsia), a stálou vlhkost vzduchu (tato hodnota se standardnì pohybuje mezi 30 a 60 procenty).\n\rBiosauny také èasto vyuívají aromaterapii – spolu s párou v ní tak návštìvníci mohou inhalovat esenciální oleje.");
    public static string enBioSaunaText = ("Among the relatively new types of saunas, there are bio saunas.\n\rTheir specificity lies in the fact that they are heated by stoves with a vaporizer, which can maintain a constant temperature (around 60 degrees Celsius) and a constant humidity level (typically ranging from 30 to 60 percent) inside the sauna.\n\rBio saunas often incorporate aromatherapy as well, allowing visitors to inhale essential oils along ");
    public static string deBioSaunaText = ("Zu den relativ neuen Arten von Saunen gehört die Biosauna.\n\rIhre Besonderheit besteht darin, dass sie mit Öfen und einem Verdampfer beheizt wird, die eine konstante Temperatur (etwa 60 Grad Celsius) und eine konstante Luftfeuchtigkeit (normalerweise zwischen 30 und 60 Prozent) in der Sauna aufrechterhalten können.\n\rBiosaunen verwenden oft auch Aromatherapie, wodurch Besucher neben dem Dampf auch ätherische Öle inhalieren können. ");

    public static string czFinSaunaText = ("Finská sauna je provìøenou klasikou, která vám pomùe vyplavit z tìla toxiny, prokrvit orgány i kùi, posílit imunitu a zbavit se stresu.\n\rPomáhá navíc i s léèbou tzv. syndromu studenıch nohou.\n\rTeplota se v klasické finské saunì pohybuje v rozmezí od 85 do 95 stupòù Celsia.\n\rVlhkost vzduchu je pak mezi 10 a 20 procenty.");
    public static string enFinSaunaText = ("The Finnish sauna is a time-tested classic that helps eliminate toxins from the body, improve blood circulation to organs and skin, boost immunity, and reduce stress.\n\rIt also aids in the treatment of the so called \"cold feet syndrome.\"\n\rThe temperature in a traditional Finnish sauna ranges from 85 to 95 degrees Celsius.\n\rThe humidity level is typically between 10 and 20 percent. ");
    public static string deFinSaunaText = ("Die finnische Sauna ist ein bewährter Klassiker, der dabei hilft, Giftsto?e aus dem Körper auszuschwemmen, die Durchblutung von Organen und Haut zu verbessern, das Immunsystem zu stärken und Stress abzubauen.\n\rSie trägt auch zur Behandlung des sogenannten \"kalte Füße-Syndroms\" bei.\n\rDie Temperatur in einer klassischen finnischen Sauna liegt zwischen 85 und 95 Grad Celsius.\n\rDie Luftfeuchtigkeit beträgt normalerweise zwischen 10 und 20 Prozent.");

    public static string czTropSaunaText = ("V tropické saunì je obvyklá teplota od 65 do 75°C.\n\rAby byly zachovány ozdravné úèinky tradièní finské sauny, je niší teplota kompenzována vyšší vlhkostí, která dosahuje hodnot mezi 50 a 60 procenty.\n\rTo navazuje atmosféru tropickıch lesù a samotného tropického klima, které je hodnì navštìvovaná lidmi s dıchacími potíemi jako napøíklad astma, nebo i rùznımi svalovımi onemocnìními. ");
    public static string enTropSaunaText = ("In the tropical sauna, the typical temperature ranges from 65 to 75°C.\n\rTo preserve the beneficial effects of the traditional Finnish sauna, the lower temperature is compensated by higher humidity, which reaches values between 50 and 60 percent.\n\rThis creates an atmosphere reminiscent of tropical forests and the actual tropical climate.\n\rThe tropical sauna is often frequented by people with respiratory issues such as asthma, as well as various muscular conditions. ");
    public static string deTropSaunaText = ("In der tropischen Sauna liegt die übliche Temperatur zwischen 65 und 75°C.\n\rUm die heilsamen Effekte der traditionellen finnischen Sauna beizubehalten, wird die niedrigere Temperatur durch eine höhere Luftfeuchtigkeit von etwa 50 bis 60 Prozent ausgeglichen.\n\rDies schafft eine Atmosphäre, die an tropische Wälder und das tatsächliche tropische Klima erinnert.\n\rDie tropische Sauna wird oft von Menschen mit Atemwegserkrankungen wie Asthma sowie verschiedenen Muskelerkrankungen besucht. ");

    public static string czSaltSaunaText = ("Teplo v saunì otevírá póry, èím usnadòuje vstøebávání minerálù obsaenıch v soli. Zároveò dochází vlivem tepla i k lepšímu prokrvení kùe. Díky kombinaci tìchto dvou úèinkù solná sauna zklidòuje zánìtlivé reakce, zmíròuje zèervenání, svìdìní i vysoušení a zanechává ple vláènìjší a jemnìjší.\n\r\n\rDoplòkem této sauny je solnı aerosol , kterı si sami zapnìte!\n\r\n\rSuchı solnı rozprašovaè distribuuje jemnı solnı aerosol, kterı se šíøí celım dıchacím systémem z nosu do dutin, hrdla a do nejvzdálenìjších plic. Zaijte støedomoøskı vzduch ve své infraèervené kabinì èi saunì.\n\r\n\rMicrosalt ProX se doporuèuje zejména pokud trpíte sennou rımou, astma, bronchitidou, cystickou fibrózou nebo chronickım onemocnìním plic. Pøípravek Microsalt je urèen také lidem, kteøí èasto trpí nachlazením nebo musejí èelit potíím s dutinami, ale také lidem s koními potíemi, èi problémy se spánkem.\n\r\n\rJednoduše vlote zaøízení do kabiny pøedehøáté na 30 a 50 ° C, zapnìte hlavní vypínaè a zasuòte solnou misku do zaøízení. Po zapnutí zaène zaøízení vyrábìt solnı aerosol. Asi po deseti minutách je dosaeno optimální koncentrace suché soli a barva osvìtlení se zmìní z oranové na modrou. Poté mùete zaèít inhalovat. Po hodinì se zaøízení automaticky vypne.\r\nV apartmánu máte nabíjeèku. Pokud váš pobyt v apartmánu je nìkolik dní, je nutné pøístroj nabít. \r\nDoba nabití je kolem dvaceti minut. Nabíjeèku máte umístìnou na sklenìném stoleèku vedle vitríny.");
    public static string enSaltSaunaText = ("Heat in the sauna opens the pores, making it easier for the body to absorb minerals contained in salt. At the same time, the heat improves blood circulation in the skin. Due to the combination of these two effects, the salt sauna soothes inflammatory reactions, reduces redness, itching, and dryness, leaving the skin more hydrated and smoother.\r\n\r\nAs an additional feature, there is a salt aerosol in this sauna. You can activate it yourself!\r\n\r\nThe dry salt sprayer distributes fine salt aerosol, which spreads throughout the respiratory system from the nose to the sinuses, throat, and even the deepest parts of the lungs. Experience the Mediterranean air in your infrared cabin or sauna. Microsalt ProX is recommended especially if you suffer from hay fever, asthma, bronchitis, cystic fibrosis, or chronic lung disease. Microsalt is also suitable for people who frequently experience colds or sinus problems, as well as those with skin conditions or sleep issues.\r\n\r\nSimply place the device in a cabin preheated to 30 to 50 °C, turn on the main switch, and insert the salt bowl into the device. Once turned on, the device will start producing salt aerosol. After about ten minutes, the optimal concentration of dry salt is achieved, and the color of the illumination changes from orange to blue. You can then start inhaling. The device will automatically turn off after one hour.\r\nYou have a charger in the apartment. If your stay in the apartment is several days, it is necessary to recharge the device. The charging time is about twenty minutes. The charger is placed on a glass table next to the display cabinet.");
    public static string deSaltSaunaText = ("Die Hitze in der Sauna öffnet die Poren und erleichtert so die Aufnahme von Mineralien, die im Salz enthalten sind. Gleichzeitig verbessert die Wärme die Durchblutung der Haut. Durch die Kombination dieser beiden Effekte beruhigt die Salzsauna entzündliche Reaktionen, reduziert Rötungen, Juckreiz und Trockenheit und hinterlässt die Haut feucht und weich.\r\n\r\nAls zusätzliches Merkmal gibt es in dieser Sauna einen Salzaerosol. Sie können ihn selbst aktivieren!\r\n\r\nDer trockene Salzzerstäuber verteilt feinen Salzaerosol, der sich im gesamten Atmungssystem von der Nase über die Nebenhöhlen, den Rachen und sogar bis in die tiefsten Teile der Lunge verteilt. Erleben Sie die mediterrane Luft in Ihrer Infrarotkabine oder Sauna. Microsalt ProX wird insbesondere empfohlen, wenn Sie an Heuschnupfen, Asthma, Bronchitis, Zystischer Fibrose oder chronischen Lungenerkrankungen leiden. Microsalt eignet sich auch für Menschen, die häufig Erkältungen oder Probleme mit den Nasennebenhöhlen haben, sowie für Personen mit Hautproblemen oder Schlafstörungen.\r\n\r\nPlatzieren Sie das Gerät einfach in einer auf 30 bis 50 °C vorgeheizten Kabine, schalten Sie den Hauptschalter ein und setzen Sie die Salzschale in das Gerät ein. Sobald es eingeschaltet ist, beginnt das Gerät, Salzaerosol zu erzeugen. Nach etwa zehn Minuten wird die optimale Konzentration an trockenem Salz erreicht und die Farbe der Be");

    public string industrial = "Industrial";
    public string wooden = "Wooden";
    public string waikiki = "Waikiki";
    public string stone = "Stone";
    public string salt = "Salt";
    public string bio = "Bio";

    public GameObject aptPanel;
    public TMP_Text aptText;
    public static bool aptBool;
    public TMP_Text date;
    private void Start()
    {
        // Assign the toggle group to each toggle
        bioSauna.group = saunaToggleGroup;
        finParaSauna.group = saunaToggleGroup;
        finSauna.group = saunaToggleGroup;
        tropSauna.group = saunaToggleGroup;
        saltSauna.group = saunaToggleGroup;
        stoneSauna.group = saunaToggleGroup;

        // Subscribe to the onValueChanged event of each toggle
        bioSauna.onValueChanged.AddListener(OnToggleValueChanged);
        finParaSauna.onValueChanged.AddListener(OnToggleValueChanged);
        stoneSauna.onValueChanged.AddListener(OnToggleValueChanged);
        finSauna.onValueChanged.AddListener(OnToggleValueChanged);
        tropSauna.onValueChanged.AddListener(OnToggleValueChanged);
        saltSauna.onValueChanged.AddListener(OnToggleValueChanged);
        LoadToggles();

        currentText = czFinSaunaText;
    }

    private void Update()
    {
        // Check for language changes and update the text accordingly
        int currentLanguage = Languages.globalLang;

        // Check the current toggle and update the text based on the selected toggle and language
        if (bioSauna.isOn)
        {
            aptText.text = bio; 
            switch (currentLanguage)
            {
                case 0:
                    currentText = czBioSaunaText;
                    break;
                case 1:
                    currentText = enBioSaunaText;
                    break;
                case 2:
                    currentText = deBioSaunaText;
                    break;
            }
        }
        else if (finParaSauna.isOn)
        {
            aptText.text = industrial;
            switch (currentLanguage)
            {
                case 0:
                    currentText = czFinParaSaunaText;
                    break;
                case 1:
                    currentText = enFinParaSaunaText;
                    break;
                case 2:
                    currentText = deFinParaSaunaText;
                    break;
            }
        }
        else if (finSauna.isOn)
        {
            aptText.text = wooden;
            switch (currentLanguage)
            {
                case 0:
                    currentText = czFinSaunaText;
                    break;
                case 1:
                    currentText = enFinSaunaText;
                    break;
                case 2:
                    currentText = deFinSaunaText;
                    break;
            }
        }
        else if (tropSauna.isOn)
        {
            aptText.text = waikiki;
            switch (currentLanguage)
            {
                case 0:
                    currentText = czTropSaunaText;
                    break;
                case 1:
                    currentText = enTropSaunaText;
                    break;
                case 2:
                    currentText = deTropSaunaText;
                    break;
            }
        }
        else if (saltSauna.isOn)
        {
            aptText.text = salt;
            switch (currentLanguage)
            {
                case 0:
                    currentText = czSaltSaunaText;
                    break;
                case 1:
                    currentText = enSaltSaunaText;
                    break;
                case 2:
                    currentText = deSaltSaunaText;
                    break;
            }
        }
        else if (stoneSauna.isOn)
        {
            aptText.text = stone;
            switch (currentLanguage)
            {
                case 0:
                    currentText = czFinSaunaText;
                    break;
                case 1:
                    currentText = enFinSaunaText;
                    break;
                case 2:
                    currentText = deFinSaunaText;
                    break;
            }
        }

        
    }

    private void OnToggleValueChanged(bool isOn)
    {

        SaveToggles();
    }

    public void SaunaButton()
    {
        if (testttt.vIsOn == true)
        {
            if(saunaBool == true)
            {
                saunaBool = false;
                saunaPanel.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                testttt.mIsOn = false;
            }
            else
            {
                testttt.vIsOn = true;
                saunaBool = true;
                saunaPanel.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                testttt.mIsOn = false;
                testttt.vBool = false;
                testttt.payBool = false;
                testttt.grillBool = false;
                testttt.kavaBool = false;
                testttt.koloBool = false;
                testttt.guestCardBool = false;
                testttt.pyroBool = false;
                testttt.snidaneBool = false;
                testttt.svickyBool = false;
                testttt.alergenBool = false;
                saunaText.text = currentText;
            }
        }
        else
        {
            saunaBool = true;
            testttt.vIsOn = true;
            saunaPanel.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            testttt.mIsOn = false;
            saunaText.text = currentText;
        }
    }



    public void SaveToggles()
    {
        PlayerPrefs.SetInt("bioSaunaToggle", bioSauna.isOn ? 1 : 0);
        PlayerPrefs.SetInt("finParaSaunaToggle", finParaSauna.isOn ? 1 : 0);
        PlayerPrefs.SetInt("finSaunaToggle", finSauna.isOn ? 1 : 0);
        PlayerPrefs.SetInt("tropSaunaToggle", tropSauna.isOn ? 1 : 0);
        PlayerPrefs.SetInt("saltSaunaToggle", saltSauna.isOn ? 1 : 0);
        PlayerPrefs.SetInt("stoneSaunaToggle", stoneSauna.isOn ? 1 : 0);

    }

    private void LoadToggles()
    {
        if (PlayerPrefs.HasKey("bioSaunaToggle"))
        {
        bioSauna.isOn = PlayerPrefs.GetInt("bioSaunaToggle", 0) == 1;
        }

        if (PlayerPrefs.HasKey("finParaSaunaToggle"))
        {
            finParaSauna.isOn = PlayerPrefs.GetInt("finParaSaunaToggle", 0) == 1;
        }

        if (PlayerPrefs.HasKey("finSaunaToggle"))
        {
            finSauna.isOn = PlayerPrefs.GetInt("finSaunaToggle", 0) == 1;
        }

        if (PlayerPrefs.HasKey("tropSaunaToggle"))
        {
            tropSauna.isOn = PlayerPrefs.GetInt("tropSaunaToggle", 0) == 1;
        }

        if (PlayerPrefs.HasKey("saltSaunaToggle"))
        {
            saltSauna.isOn = PlayerPrefs.GetInt("saltSaunaToggle", 0) == 1;
        }

        if (PlayerPrefs.HasKey("stoneSaunaToggle"))
        {
            stoneSauna.isOn = PlayerPrefs.GetInt("stoneSaunaToggle", 0) == 1;
        }
    }

    public void ChangeAp()
    {
        if (aptBool == true)
        {
            aptBool = false;
            aptPanel.SetActive(false);
        }
        else
        {
            aptPanel.SetActive(true);
            aptBool = true;

         
        }
    }

    public void SetAptBool()
    {
        aptBool = false;
    }
}
