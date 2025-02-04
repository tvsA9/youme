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

    public static string czFinParaSaunaText = ("Tato varianta finsk� sauny je vybavena za��zen�m, kter� v pravideln�ch intervalech pol�v� rozp�len� kameny na kamnech vodou a hork� vzduch pak rozfouk� po saun�.\r\nKa�d�ch p�r minut tak va�e t�lo zas�hne intenzivn� tepeln� vlna, kter� zv��� va�e vn�m�n� pocitov�ho tepla.\r\nSauna v�m pom��e vyplavit z t�la toxiny, prokrvit org�ny i k��i, pos�lit imunitu a zbavit se stresu.\r\nTeplota se v klasick� finsk� saun� pohybuje v rozmez� od 85 do 95 stup�� Celsia. Vlhkost vzduchu je pak mezi 10 a 20 procenty. ");
    public static string enFinParaSaunaText = ("This variation of the Finnish sauna is equipped with a device that regularly pours water over the hot stones on the stove, creating a burst of steam that is circulated throughout the sauna.\n\rEvery few minutes, your body will experience an intense wave of heat, enhancing your perception of warmth.\n\rThe sauna helps eliminate toxins from your body, improves blood circulation to organs and skin, boosts immunity, and helps reduce stress.\n\rThe temperature in a traditional Finnish sauna ranges from 85 to 95 degrees Celsius. The humidity level is typically between 10 and 20 percent.");
    public static string deFinParaSaunaText = ("Diese Variante der finnischen Sauna ist mit einer Vorrichtung ausgestattet, die in regelm��igen Abst�nden Wasser �ber die hei�en Steine auf dem Ofen gie�t und so einen Dampfsto� erzeugt, der sich in der gesamten Sauna verteilt. Alle paar Minuten wird Ihr K�rper von einer intensiven Hitzewelle erfasst, was Ihre Wahrnehmung von W�rme verst�rkt. Die Sauna hilft dabei, Giftsto?e aus Ihrem K�rper auszuschwemmen, verbessert die Durchblutung von Organen und Haut, st�rkt das Immunsystem und hilft beim Stressabbau. Die Temperatur in einer klassischen finnischen Sauna liegt zwischen 85 und 95 Grad Celsius. Die Luftfeuchtigkeit betr�gt normalerweise zwischen 10 und 20 Prozent. ");

    public static string czBioSaunaText = ("Mezi pom�rn� nov� druhy saun pat�� biosauny.\n\rJejich specifikum spo��v� v tom, �e jsou vyt�p�ny kamny s v�parn�kem, kter� uvnit� sauny dok�ou udr�ovat st�lou teplotu (kolem 60 stup�� Celsia), a st�lou vlhkost vzduchu (tato hodnota se standardn� pohybuje mezi 30 a 60 procenty).\n\rBiosauny tak� �asto vyu��vaj� aromaterapii � spolu s p�rou v n� tak n�v�t�vn�ci mohou inhalovat esenci�ln� oleje.");
    public static string enBioSaunaText = ("Among the relatively new types of saunas, there are bio saunas.\n\rTheir specificity lies in the fact that they are heated by stoves with a vaporizer, which can maintain a constant temperature (around 60 degrees Celsius) and a constant humidity level (typically ranging from 30 to 60 percent) inside the sauna.\n\rBio saunas often incorporate aromatherapy as well, allowing visitors to inhale essential oils along ");
    public static string deBioSaunaText = ("Zu den relativ neuen Arten von Saunen geh�rt die Biosauna.\n\rIhre Besonderheit besteht darin, dass sie mit �fen und einem Verdampfer beheizt wird, die eine konstante Temperatur (etwa 60 Grad Celsius) und eine konstante Luftfeuchtigkeit (normalerweise zwischen 30 und 60 Prozent) in der Sauna aufrechterhalten k�nnen.\n\rBiosaunen verwenden oft auch Aromatherapie, wodurch Besucher neben dem Dampf auch �therische �le inhalieren k�nnen. ");

    public static string czFinSaunaText = ("Finsk� sauna je prov��enou klasikou, kter� v�m pom��e vyplavit z t�la toxiny, prokrvit org�ny i k��i, pos�lit imunitu a zbavit se stresu.\n\rPom�h� nav�c i s l��bou tzv. syndromu studen�ch nohou.\n\rTeplota se v klasick� finsk� saun� pohybuje v rozmez� od 85 do 95 stup�� Celsia.\n\rVlhkost vzduchu je pak mezi 10 a 20 procenty.");
    public static string enFinSaunaText = ("The Finnish sauna is a time-tested classic that helps eliminate toxins from the body, improve blood circulation to organs and skin, boost immunity, and reduce stress.\n\rIt also aids in the treatment of the so called \"cold feet syndrome.\"\n\rThe temperature in a traditional Finnish sauna ranges from 85 to 95 degrees Celsius.\n\rThe humidity level is typically between 10 and 20 percent. ");
    public static string deFinSaunaText = ("Die finnische Sauna ist ein bew�hrter Klassiker, der dabei hilft, Giftsto?e aus dem K�rper auszuschwemmen, die Durchblutung von Organen und Haut zu verbessern, das Immunsystem zu st�rken und Stress abzubauen.\n\rSie tr�gt auch zur Behandlung des sogenannten \"kalte F��e-Syndroms\" bei.\n\rDie Temperatur in einer klassischen finnischen Sauna liegt zwischen 85 und 95 Grad Celsius.\n\rDie Luftfeuchtigkeit betr�gt normalerweise zwischen 10 und 20 Prozent.");

    public static string czTropSaunaText = ("V tropick� saun� je obvykl� teplota od 65 do 75�C.\n\rAby byly zachov�ny ozdravn� ��inky tradi�n� finsk� sauny, je ni��� teplota kompenzov�na vy��� vlhkost�, kter� dosahuje hodnot mezi 50 a 60 procenty.\n\rTo navazuje atmosf�ru tropick�ch les� a samotn�ho tropick�ho klima, kter� je hodn� nav�t�vovan� lidmi s d�chac�mi pot�emi jako nap��klad astma, nebo i r�zn�mi svalov�mi onemocn�n�mi. ");
    public static string enTropSaunaText = ("In the tropical sauna, the typical temperature ranges from 65 to 75�C.\n\rTo preserve the beneficial effects of the traditional Finnish sauna, the lower temperature is compensated by higher humidity, which reaches values between 50 and 60 percent.\n\rThis creates an atmosphere reminiscent of tropical forests and the actual tropical climate.\n\rThe tropical sauna is often frequented by people with respiratory issues such as asthma, as well as various muscular conditions. ");
    public static string deTropSaunaText = ("In der tropischen Sauna liegt die �bliche Temperatur zwischen 65 und 75�C.\n\rUm die heilsamen Effekte der traditionellen finnischen Sauna beizubehalten, wird die niedrigere Temperatur durch eine h�here Luftfeuchtigkeit von etwa 50 bis 60 Prozent ausgeglichen.\n\rDies schafft eine Atmosph�re, die an tropische W�lder und das tats�chliche tropische Klima erinnert.\n\rDie tropische Sauna wird oft von Menschen mit Atemwegserkrankungen wie Asthma sowie verschiedenen Muskelerkrankungen besucht. ");

    public static string czSaltSaunaText = ("Teplo v saun� otev�r� p�ry, ��m� usnad�uje vst�eb�v�n� miner�l� obsa�en�ch v soli. Z�rove� doch�z� vlivem tepla i k lep��mu prokrven� k��e. D�ky kombinaci t�chto dvou ��ink� soln� sauna zklid�uje z�n�tliv� reakce, zm�r�uje z�erven�n�, sv�d�n� i vysou�en� a zanech�v� ple� vl��n�j�� a jemn�j��.\n\r\n\rDopl�kem t�to sauny je soln� aerosol , kter� si sami zapn�te!\n\r\n\rSuch� soln� rozpra�ova� distribuuje jemn� soln� aerosol, kter� se ���� cel�m d�chac�m syst�mem z nosu do dutin, hrdla a do nejvzd�len�j��ch plic. Za�ijte st�edomo�sk� vzduch ve sv� infra�erven� kabin� �i saun�.\n\r\n\rMicrosalt ProX se doporu�uje zejm�na pokud trp�te sennou r�mou, astma, bronchitidou, cystickou fibr�zou nebo chronick�m onemocn�n�m plic. P��pravek Microsalt je ur�en tak� lidem, kte�� �asto trp� nachlazen�m nebo musej� �elit pot��m s dutinami, ale tak� lidem s ko�n�mi pot�emi, �i probl�my se sp�nkem.\n\r\n\rJednodu�e vlo�te za��zen� do kabiny p�edeh��t� na 30 a� 50 � C, zapn�te hlavn� vyp�na� a zasu�te solnou misku do za��zen�. Po zapnut� za�ne za��zen� vyr�b�t soln� aerosol. Asi po deseti minut�ch je dosa�eno optim�ln� koncentrace such� soli a barva osv�tlen� se zm�n� z oran�ov� na modrou. Pot� m��ete za��t inhalovat. Po hodin� se za��zen� automaticky vypne.\r\nV apartm�nu m�te nab�je�ku. Pokud v� pobyt v apartm�nu je n�kolik dn�, je nutn� p��stroj nab�t. \r\nDoba nabit� je kolem dvaceti minut. Nab�je�ku m�te um�st�nou na sklen�n�m stole�ku vedle vitr�ny.");
    public static string enSaltSaunaText = ("Heat in the sauna opens the pores, making it easier for the body to absorb minerals contained in salt. At the same time, the heat improves blood circulation in the skin. Due to the combination of these two effects, the salt sauna soothes inflammatory reactions, reduces redness, itching, and dryness, leaving the skin more hydrated and smoother.\r\n\r\nAs an additional feature, there is a salt aerosol in this sauna. You can activate it yourself!\r\n\r\nThe dry salt sprayer distributes fine salt aerosol, which spreads throughout the respiratory system from the nose to the sinuses, throat, and even the deepest parts of the lungs. Experience the Mediterranean air in your infrared cabin or sauna. Microsalt ProX is recommended especially if you suffer from hay fever, asthma, bronchitis, cystic fibrosis, or chronic lung disease. Microsalt is also suitable for people who frequently experience colds or sinus problems, as well as those with skin conditions or sleep issues.\r\n\r\nSimply place the device in a cabin preheated to 30 to 50 �C, turn on the main switch, and insert the salt bowl into the device. Once turned on, the device will start producing salt aerosol. After about ten minutes, the optimal concentration of dry salt is achieved, and the color of the illumination changes from orange to blue. You can then start inhaling. The device will automatically turn off after one hour.\r\nYou have a charger in the apartment. If your stay in the apartment is several days, it is necessary to recharge the device. The charging time is about twenty minutes. The charger is placed on a glass table next to the display cabinet.");
    public static string deSaltSaunaText = ("Die Hitze in der Sauna �ffnet die Poren und erleichtert so die Aufnahme von Mineralien, die im Salz enthalten sind. Gleichzeitig verbessert die W�rme die Durchblutung der Haut. Durch die Kombination dieser beiden Effekte beruhigt die Salzsauna entz�ndliche Reaktionen, reduziert R�tungen, Juckreiz und Trockenheit und hinterl�sst die Haut feucht und weich.\r\n\r\nAls zus�tzliches Merkmal gibt es in dieser Sauna einen Salzaerosol. Sie k�nnen ihn selbst aktivieren!\r\n\r\nDer trockene Salzzerst�uber verteilt feinen Salzaerosol, der sich im gesamten Atmungssystem von der Nase �ber die Nebenh�hlen, den Rachen und sogar bis in die tiefsten Teile der Lunge verteilt. Erleben Sie die mediterrane Luft in Ihrer Infrarotkabine oder Sauna. Microsalt ProX wird insbesondere empfohlen, wenn Sie an Heuschnupfen, Asthma, Bronchitis, Zystischer Fibrose oder chronischen Lungenerkrankungen leiden. Microsalt eignet sich auch f�r Menschen, die h�ufig Erk�ltungen oder Probleme mit den Nasennebenh�hlen haben, sowie f�r Personen mit Hautproblemen oder Schlafst�rungen.\r\n\r\nPlatzieren Sie das Ger�t einfach in einer auf 30 bis 50 �C vorgeheizten Kabine, schalten Sie den Hauptschalter ein und setzen Sie die Salzschale in das Ger�t ein. Sobald es eingeschaltet ist, beginnt das Ger�t, Salzaerosol zu erzeugen. Nach etwa zehn Minuten wird die optimale Konzentration an trockenem Salz erreicht und die Farbe der Be");

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
