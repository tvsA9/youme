using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System.Linq;
using Unity.VisualScripting;
using System.Collections;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using System.Numerics;
using UnityEditor;
using JetBrains.Annotations;

public class testttt : MonoBehaviour
{
    public GameObject anim; // Reference to the Animator component
    public GameObject menuPanel;
    public GameObject langPanel;
    public static bool mIsOn = false;
    public TMP_Text virivkaText; // Reference to the text GameObject
    public GameObject newsPanel;
    public GameObject saunaPanel;
    public static bool vIsOn = false;
    public GameObject browserPanel;
    public TMP_Text browserText;

    public GameObject alergeny;

    public string czBrowser = "Pro aktuální menu a objednávky, použijte druhou ikonu na ploše: Vivaldi Browser. Dìkujeme.";
    public string enBrowser = "For the current menu and orders, use the second icon on the desktop: Vivaldi Browser. Thank you.";
    public string deBrowser = "Für das aktuelle Menü und Bestellungen verwenden Sie das zweite Symbol auf dem Desktop: Vivaldi Browser. Vielen Dank.";

    public static bool vBool;
    public static bool payBool;
    public static bool wifiBool;
    public static bool grillBool;
    public static bool kavaBool;
    public static bool koloBool;
    public static bool guestCardBool;
    public static bool pyroBool;
    public static bool snidaneBool;
    public static bool svickyBool;
    public static bool alergenBool;

    public static string CZvButton = "Víøivku si mùžete kdykoliv napustit nebo vypustit stiskem zeleného tlaèítka se symbolem kohoutku.\r\nVíøivka se automaticky po 90 minutách provozu zaène sama vypouštìt.\r\n\r\nZastavit vypouštìní – stisknìte lehce zelené tlaèítko s kohoutkem – svìtlo musí blikat – víøivka se napouští Vypouštìní víøivky – zelené svìtlo se symbolem kohoutku svítí trvale.\r\nStejný režim mají i ostatní tlaèítka mimo svìtla.\r\n\r\nKdyž svìtýlka na tlaèítkách blikají – bublinka masáž je spuštìna. Když svìtýlka na tlaèítkách trvale svítí – nedìje se nic.";
    public static string CZpayButton = "Vaši útratu máte možnost uhradit pøímo v tabletu v záložce ,,Zaplatit‘‘ (vlevo nahoøe).\r\nÚhradu je možné provést platební kartou nebo pøes mobilní telefon pomocí QR kódu.\r\nDále je možné zaplatit pøes Apple Pay a Google Pay.\r\n\r\nSamozøejmì i nadále mùžete platit hotovì nebo kartou na recepci.";
    public static string CZwifiButton = "Název sítì: You&Me_host\r\n\r\nHeslo: Wellnessrezort";
    public static string CZgrillButton = "Grilovací sezóna probíhá v období od\r\n1. 4. do 31. 10.\r\n\r\nMimo grilovací sezónu lze opékat špekáèky na pøiložených tyèích nebo si mùžete kdokoliv jen zapálit oheò.\r\nV pøípadì, že byste mìli zájem o grilování mimo grilovací sezónu, prosím kontaktujte personál, grilovací sety lze objednat bìhem celého roku.\r\n\r\nPøed použitím nechte gril poøádnì rozpálit.\r\n\r\nProsíme po použití gril zavøít, nesmí do nìj napršet.\r\n\r\nDìkujeme.";
    public static string CZkavaButton = "Pro použití kávovaru:\r\n\r\n\r\n1.\r\nNaplòte nádobu na vodu. Kávovar nesmí bìžet bez vody.\r\n\r\n2.\r\nVložte kapsli do zásobníku a zavøete.\r\n\r\n3.\r\nKoleèkem si nastavíte velikost šálku a stisknutím tlaèítka šálku spustíte kávovar, opìtovným stiskem kávovar zastaví.\r\n\r\n\r\n\r\nLatté a cappuccino se pøipravuje ze dvou kapslí, nejprve vložte bílý kelímek, poté hnìdý.";
    public static string CZkoloButton = "V pøípadì zájmu si mùžete vypùjèit elektrokola.\r\n\r\nDenní pronájem za kolo: 1 200 Kè\r\n\r\nPùldenní pronájem za kolo: 650 Kè";
    public static string CZguestCardButton = "Vážení hosté,\r\n\r\nPo vašem pøíjezdu Vás žádáme o vyplnìní ,,Registraèní karty hosta‘‘, kterou jsme ze zákona, §7 zákona è.565/1990 Sb., povinni pøedložit každému ubytovanému hostu na noc k vyplnìní a vaše povinnost je ji vyplnit. \r\n\r\nRegistraèní karty nám mùžete zanechat na kuchyòské lince u okénka a my si je, co nejdøíve vyzvedneme.";
    public static string CZpyroButton = "Vážení hosté,\r\n\r\nv celém našem resortu je zákaz používání jakékoliv pyrotechniky.\r\n\r\nŽádáme Vás, abyste tento zákaz respektovali.\r\n\r\nK opatøení jsme pøistoupili z bezpeènostních dùvodu – celý resort je stavìný ze døeva a také s ohledem na naše lanì a jelena.";
    public static string CZsnidaneButton = "Vážení hosté,\r\n\r\npo vašem ubytování Vás žádáme o objednání snídanì a o sdìlení hodiny, kdy ji budete chtít donést.\r\n\r\nVeškerá vaše pøání nám mùžete napsat do kolonky POZNÁMKY nebo zavolat telefonem.";
    public static string CZsvickyButton = "Prosíme o používání výhradnì našich svíèek na místech, kde jsou umístìny.\r\n\r\nZ bezpeènostních dùvodu je zákaz používání vlastních svíèek v prostorách apartmánu.";

    public static string ENvButton = "You can fill or drain the hot tub at any time by pressing the green button with the tap symbol.\r\nThe hot tub will automatically drain itself after 90 minutes of operation.\r\n\r\nStop draining - press the green button with the tap lightly - the light must flash - the hot tub is filling Draining the whirlpool - the green light with the tap symbol is permanently lit.\r\n\r\nThe other buttons outside the light have the same mode.\r\n\r\nWhen the lights on the buttons flash - the bubble massage is started. When the lights on the buttons are permanently lit - nothing happens.";
    public static string ENpayButton = "You have the option to pay your bill directly on the tablet under the \"Pay\" tab (top left).\r\nPayment can be made with a credit card or through your mobile phone using a QR code.\r\nAdditionally, you can pay with Apple Pay and Google Pay.\r\n\r\nOf course, you can still pay in cash or with a card at the reception.";
    public static string ENwifiButton = "Network name: You&Me_host\r\nPassword: Wellnessrezort";
    public static string ENgrillButton = "The grilling season takes place from\r\nApril 1st to October 31st.\r\n\r\nOutside of the grilling season, you can roast sausages on the provided sticks or simply start a fire.\r\nIf you are interested in grilling outside of the grilling season, please contact the staff. The grill sets can be ordered anytime throughout the year.\r\n\r\nBefore using, make sure to properly heat up the grill.\r\n\r\nPlease close the grill after use. It must not get wet.\r\n\r\nThank you.";
    public static string ENkavaButton = "For the use of the coffee machine:\r\n\r\n\r\n1.\r\nFill the water container. The coffee machine must not run without water.\r\n\r\n2.\r\nInsert the capsule into the holder and close it.\r\n\r\n3.\r\nUse the dial to adjust the cup size, and press the cup button to start the coffee machine. Press the button again to stop the coffee machine.\r\n\r\n\r\n\r\nLatté and cappuccino are prepared using two capsules. First, insert the white cup, and then the brown one.";
    public static string ENkoloButton = "In case of interest, you can rent e-bikes.\r\n\r\nDaily rental per bike: 1,200 CZK\r\n\r\nHalf-day rental per bike: 650 CZK";
    public static string ENguestCardButton = "Dear guests,\r\n\r\nUpon your arrival, we kindly ask you to fill out the \"Guest Registration Form,\" which, according to the law, §7 of Act No. 565/1990 Coll., we are obligated to present to each guest staying overnight for completion, and it is your obligation to fill it out.\r\n\r\nYou can leave the registration forms on the kitchen counter at the window, and we will collect them as soon as possible.";
    public static string ENpyroButton = "Dear guests,\r\n\r\nThroughout our resort, the use of any fireworks is strictly prohibited.\r\n\r\nWe kindly ask you to respect this prohibition.\r\n\r\nThis measure has been taken for safety reasons – the entire resort is built of wood, and also in consideration of our does and deer.\r\n";
    public static string ENsnidaneButton = "Dear guests,\r\n\r\nThroughout your accommodation, we kindly ask you to order breakfast and to inform us of the time you would like it to be delivered.\r\n\r\nYou can write all your requests in the NOTES column or call us by phone.\r\n";
    public static string ENsvickyButton = "We kindly ask for the exclusive use of our candles in the designated areas.\r\n\r\nFor safety reasons, using personal candles in the apartment spaces is prohibited.\r\n";


    public static string DEvButton = "Sie können den Whirlpool jederzeit füllen oder entleeren, indem Sie die grüne Taste mit dem Hahnsymbol drücken.\r\nDer Whirlpool entleert sich nach 90 Minuten Betrieb automatisch.\r\n\r\nEntleerung stoppen - die grüne Taste mit dem Wasserhahn leicht drücken - die Leuchte muss blinken - der Whirlpool füllt sich - die grüne Leuchte mit dem Wasserhahnsymbol leuchtet dauerhaft.\r\n\r\nDie anderen Tasten außerhalb des Lichts haben den gleichen Modus.\r\n\r\nWenn die Lichter auf den Tasten blinken - die Sprudelmassage wird gestartet. Wenn die Lichter auf den Tasten dauerhaft leuchten - passiert nichts.";
    public static string DEpayButton = "Sie haben die Möglichkeit, Ihre Rechnung direkt auf dem Tablet im Tab \"Bezahlen\" (oben links) zu begleichen.\r\nDie Zahlung kann mit einer Kreditkarte oder über Ihr Mobiltelefon mithilfe eines QR-Codes erfolgen.\r\nAußerdem ist es möglich, mit Apple Pay und Google Pay zu bezahlen.\r\n\r\nNatürlich können Sie weiterhin bar oder mit Karte an der Rezeption bezahlen.";
    public static string DEwifiButton = "Name des Netzes: You&Me_host\r\nPasswort: Wellnessrezort";
    public static string DEgrillButton = "Die Grillsaison findet statt vom\r\n1. April bis 31. Oktober.\r\n\r\nAußerhalb der Grillsaison können Sie Würstchen auf den bereitgestellten Stöcken rösten oder jeder kann einfach ein Feuer entfachen.\r\nWenn Sie außerhalb der Grillsaison Interesse am Grillen haben, kontaktieren Sie bitte das Personal; Grillsets können das ganze Jahr über bestellt werden.\r\n\r\nBevor Sie den Grill verwenden, stellen Sie sicher, dass er richtig aufgeheizt ist.\r\n\r\nBitte schließen Sie den Grill nach der Benutzung; er darf nicht nass werden.\r\n\r\nVielen Dank.";
    public static string DEkavaButton = "Für die Verwendung der Kaffeemaschine:\r\n\r\n\r\n1.\r\nFüllen Sie den Wasserbehälter. Die Kaffeemaschine darf nicht ohne Wasser laufen.\r\n\r\n2.\r\nLegen Sie die Kapsel in den Halter ein und schließen Sie ihn.\r\n\r\n3.\r\nVerwenden Sie das Rad, um die Tassengröße einzustellen, und drücken Sie die Tassen-Taste, um die Kaffeemaschine zu starten. Drücken Sie die Taste erneut, um die Kaffeemaschine anzuhalten.\r\n\r\n\r\n\r\nLatté und Cappuccino werden mit zwei Kapseln zubereitet. Legen Sie zuerst den weißen Becher ein und dann den braunen.";
    public static string DEkoloButton = "Bei Interesse können Sie E-Bikes ausleihen.\r\n\r\nTagesmiete/Fahrrad: 1.200 CZK\r\n\r\nHalbtagesmiete/Fahrrad: 650 CZK";
    public static string DEguestCardButton = "Sehr geehrte Gäste,\r\n\r\nNach Ihrer Ankunft bitten wir Sie, das \"Gästeregistrierungsformular\" auszufüllen, das wir gesetzlich gemäß § 7 des Gesetzes Nr. 565/1990 verpflichtet sind, jedem übernachtenden Gast vorzulegen, und es ist Ihre Pflicht, es auszufüllen.\r\n\r\nDie Registrierungsformulare können Sie auf der Küchentheke am Fenster hinterlassen, und wir werden sie so bald wie möglich abholen.";
    public static string DEpyroButton = "Sehr geehrte Gäste,\r\n\r\nIn unserem gesamten Resort ist die Verwendung von Feuerwerkskörpern strikt untersagt.\r\n\r\nWir bitten Sie höflich, dieses Verbot zu respektieren.\r\n\r\nDiese Maßnahme wurde aus Sicherheitsgründen ergriffen – das gesamte Resort ist aus Holz gebaut und auch im Hinblick auf unsere Seile und den Hirsch.\r\n";
    public static string DEsnidaneButton = "Sehr geehrte Gäste,\r\n\r\nNach Ihrer Unterbringung bitten wir Sie, das Frühstück zu bestellen und uns mitzuteilen, zu welcher Uhrzeit Sie es geliefert haben möchten.\r\n\r\nAlle Ihre Wünsche können Sie in der SPALTENNOTIZEN eintragen oder uns telefonisch kontaktieren.";
    public static string DEsvickyButton = "Bitte verwenden Sie ausschließlich unsere Kerzen an den dafür vorgesehenen Stellen, an denen sie platziert sind.\r\n\r\nAus Sicherheitsgründen ist es untersagt, eigene Kerzen in den Räumlichkeiten des Apartments zu verwenden.\r\n";




    private void Start()
    {
       

    }

    public void VButtonClicked()
    {
        if (vIsOn == true)
        {
            if (vBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vBool = false; 
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vBool=true;

                Toggles1.saunaBool = false;
                payBool=false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool= false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZvButton;
                        break;
                    case 1:
                        virivkaText.text = ENvButton;
                        break;
                    case 2:
                        virivkaText.text = DEvButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
}

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vBool = true;

            Toggles1.saunaBool = false;
            payBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZvButton;
                    break;
                case 1:
                    virivkaText.text = ENvButton;
                    break;
                case 2:
                    virivkaText.text = DEvButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void PayButtonClicked()
    {
        if (vIsOn == true)
        {
            if (payBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                payBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                payBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZpayButton;
                        break;
                    case 1:
                        virivkaText.text = ENpayButton;
                        break;
                    case 2:
                        virivkaText.text = DEpayButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            payBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZpayButton;
                    break;
                case 1:
                    virivkaText.text = ENpayButton;
                    break;
                case 2:
                    virivkaText.text = DEpayButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void WifiButtonClicked()
    {
        if (vIsOn == true)
        {
            if (wifiBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                wifiBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                wifiBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                payBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZwifiButton;
                        break;
                    case 1:
                        virivkaText.text = ENwifiButton;
                        break;
                    case 2:
                        virivkaText.text = DEwifiButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            payBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZwifiButton;
                    break;
                case 1:
                    virivkaText.text = ENwifiButton;
                    break;
                case 2:
                    virivkaText.text = DEwifiButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void GrillButtonClicked()
    {
        if (vIsOn == true)
        {
            if (grillBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                grillBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                grillBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                payBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZgrillButton;
                        break;
                    case 1:
                        virivkaText.text = ENgrillButton;
                        break;
                    case 2:
                        virivkaText.text = DEgrillButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            grillBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            payBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZgrillButton;
                    break;
                case 1:
                    virivkaText.text = ENgrillButton;
                    break;
                case 2:
                    virivkaText.text = DEgrillButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void KavaButtonClicked()
    {
        if (vIsOn == true)
        {
            if (kavaBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                kavaBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                kavaBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                payBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZkavaButton;
                        break;
                    case 1:
                        virivkaText.text = ENkavaButton;
                        break;
                    case 2:
                        virivkaText.text = DEkavaButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            kavaBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            payBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZkavaButton;
                    break;
                case 1:
                    virivkaText.text = ENkavaButton;
                    break;
                case 2:
                    virivkaText.text = DEkavaButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void KoloButtonClicked()
    {
        if (vIsOn == true)
        {
            if (koloBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                koloBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                koloBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                payBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZkoloButton;
                        break;
                    case 1:
                        virivkaText.text = ENkoloButton;
                        break;
                    case 2:
                        virivkaText.text = DEkoloButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            koloBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            payBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZkoloButton;
                    break;
                case 1:
                    virivkaText.text = ENkoloButton;
                    break;
                case 2:
                    virivkaText.text = DEkoloButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void GuestCardButtonClicked()
    {
        if (vIsOn == true)
        {
            if (guestCardBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                guestCardBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                guestCardBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                payBool = false;
                pyroBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZguestCardButton;
                        break;
                    case 1:
                        virivkaText.text = ENguestCardButton;
                        break;
                    case 2:
                        virivkaText.text = DEguestCardButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            guestCardBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            payBool = false;
            pyroBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZguestCardButton;
                    break;
                case 1:
                    virivkaText.text = ENguestCardButton;
                    break;
                case 2:
                    virivkaText.text = DEguestCardButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void PyroButtonClicked()
    {
        if (vIsOn == true)
        {
            if (pyroBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                pyroBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                pyroBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                payBool = false;
                snidaneBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZpyroButton;
                        break;
                    case 1:
                        virivkaText.text = ENpyroButton;
                        break;
                    case 2:
                        virivkaText.text = DEpyroButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            pyroBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            payBool = false;
            snidaneBool = false;
            svickyBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZpyroButton;
                    break;
                case 1:
                    virivkaText.text = ENpyroButton;
                    break;
                case 2:
                    virivkaText.text = DEpyroButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void SnidaneButtonClicked()
    {
        if (vIsOn == true)
        {
            if (snidaneBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                snidaneBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                snidaneBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                payBool = false;
                svickyBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZsnidaneButton;
                        break;
                    case 1:
                        virivkaText.text = ENsnidaneButton;
                        break;
                    case 2:
                        virivkaText.text = DEsnidaneButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            snidaneBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            payBool = false;
            svickyBool = false;
            alergenBool = false;

            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZsnidaneButton;
                    break;
                case 1:
                    virivkaText.text = ENsnidaneButton;
                    break;
                case 2:
                    virivkaText.text = DEsnidaneButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void SvickyButtonClicked()
    {
        if (vIsOn == true)
        {
            if (svickyBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                svickyBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                svickyBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                payBool = false;
                alergenBool = false;

                switch (Languages.globalLang)
                {
                    case 0:
                        virivkaText.text = CZsvickyButton;
                        break;
                    case 1:
                        virivkaText.text = ENsvickyButton;
                        break;
                    case 2:
                        virivkaText.text = DEsvickyButton;
                        break;
                }

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            svickyBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            payBool = false;
            alergenBool = false;


            switch (Languages.globalLang)
            {
                case 0:
                    virivkaText.text = CZsvickyButton;
                    break;
                case 1:
                    virivkaText.text = ENsvickyButton;
                    break;
                case 2:
                    virivkaText.text = DEsvickyButton;
                    break;
            }

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }

    public void AlergenButtonClicked()
    {
        if (vIsOn == true)
        {
            if (alergenBool == true)
            {
                vIsOn = false;
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                alergenBool = false;
            }
            else
            {
                anim.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                alergenBool = true;

                Toggles1.saunaBool = false;
                vBool = false;
                wifiBool = false;
                grillBool = false;
                kavaBool = false;
                koloBool = false;
                guestCardBool = false;
                pyroBool = false;
                snidaneBool = false;
                payBool = false;
                svickyBool = false;

                virivkaText.text = "";

                anim.GetComponent<Animation>().Play("VirivkaAnim");
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                mIsOn = false;
                vIsOn = true;
                alergeny.SetActive(true);
            }

        }
        else
        {
            anim.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            alergenBool = true;

            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            payBool = false;
            svickyBool = false;

            alergeny.SetActive(true);

            virivkaText.text = "";

            anim.GetComponent<Animation>().Play("VirivkaAnim");
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
            vIsOn = true;
        }
    }



    public void MenuButton()
    {
        if (mIsOn == false)
        {
            menuPanel.GetComponent<Animation>().Play("menuChooseRev");
            mIsOn = true;
        }
        else
        {
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;
        }
    }

    public void LangButton()
    {
        langPanel.GetComponent<Animation>().Play("langSlideRevAnim");
        if (mIsOn)
        {
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn = false;

        }
        if (vIsOn)
        {
            vIsOn = false;
            anim.GetComponent<Animation>().Play("VirivkaAnimRev");
            svickyBool = false;
            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            payBool = false;
        }
    }

    public void ButtonLink()
    {
        browserPanel.SetActive(true);
        switch (Languages.globalLang)
        {
            case 0:
                browserText.text = czBrowser;
                break;
                case 1:
                browserText.text = enBrowser;
                break;
            case 2:
                browserText.text = deBrowser;
                break;
        }
        StartCoroutine(Waiter());
        
    }

    public IEnumerator Waiter()
    {
        yield return new WaitForSeconds(8);
        browserPanel.SetActive(false);
        
    }
    public void HomeButton()
    {
		browserPanel.SetActive(false);

        if (mIsOn)
        {
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn=false;

        }
        if (vIsOn)
        {
            vIsOn = false;
            anim.GetComponent<Animation>().Play("VirivkaAnimRev");
            svickyBool = false;
            Toggles1.saunaBool = false;
            vBool = false;
            wifiBool = false;
            grillBool = false;
            kavaBool = false;
            koloBool = false;
            guestCardBool = false;
            pyroBool = false;
            snidaneBool = false;
            payBool = false;
			browserPanel.SetActive(false);
            StopAllCoroutines();
        }
    }

}
