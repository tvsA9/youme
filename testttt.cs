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

    public static string CZvButton = "Víøivku si mùžete kdykoliv napustit nebo vypustit stiskem zeleného tlaèítka se symbolem kohoutku.\r\nVíøivka se automaticky po 90 minutách provozu zaène sama vypouštìt.\r\n\r\nZastavit vypouštìní – stisknìte lehce zelené tlaèítko s kohoutkem – svìtlo musí blikat – víøivka se napouští Vypouštìní víøivky – zelené svìtlo se symbolem kohoutku svítí trvale.\r\nStejný režim mají i ostatní tlaèítka mimo svìtla.\r\n\r\nKdyž svìtýlka na tlaèítkách blikají – bublinka masáž je spuštìna. Když svìtýlka na tlaèítkách trvale svítí – nedìje se nic.";
    public static string CZpayButton = "Vaši útratu máte možnost uhradit pøímo v tabletu v záložce ,,Zaplatit‘‘ (vlevo nahoøe).\r\nJe možné provést úhradu platební kartou nebo pøes mobilní telefon pøes QR kód, který naskenujete fotoaparátem (nebo èteèkou QR kódù).\r\nDále je možné zaplatit pøes Apple Pay a Google Pay.\r\n\r\nPøípadnì i hotovì nebo kartou na recepci.";
    public static string CZwifiButton = "Název sítì: You&Me_host\r\n\r\nHeslo: Wellnessrezort";
    public static string CZgrillButton = "Pøed použitím nechte grill poøádnì rozpálit.\r\n\r\nProsíme po použití grill zavøít, nesmí do nìj napršet.\r\n\r\nDìkujeme.";
    public static string CZkavaButton = "Pro použití kávovaru:\r\n\r\n\r\n1.\r\nNaplòte nádobu na vodu. Kávovar nesmí bìžet bez vody.\r\n\r\n2.\r\nVložte kapsli do zásobníku a zavøete.\r\n\r\n3.\r\nKoleèkem si nastavíte velikost šálku a stisknutím tlaèítka šálku spustíte kávovar, opìtovným stiskem kávovar zastaví.\r\n\r\n\r\n\r\nLatté a cappuccino se pøipravuje ze dvou kapslí, nejprve vložte bílý kelímek, poté hnìdý.";
    public static string CZkoloButton = "V pøípadì zájmu si mùžete vypùjèit a vyzkoušet elektrokolo RockMachine.\r\n\r\nCena za denní pronájem:\r\n1 000 Kè";
    public static string CZguestCardButton = "Vážení hosté,\r\n\r\nprosíme Vás o vyplnìní ,,Registraèní karty hosta‘‘, kterou jsme ze zákona povinni pøedložit každému ubytovanému hostu na noc. \r\nRegistraèní karty mùžete nechat v apartmánu, po ukonèení vašeho pobytu si je vyzvedneme.";
    public static string CZpyroButton = "Vážení hosté,\r\n\r\nprosíme, abyste nepoužívali v našem resortu žádnou pyrotechniku.\r\n\r\nCelý resort je døevìný.\r\n\r\nBerte ohled na naše lanì a jelena";
    public static string CZsnidaneButton = "Po pøíjezdu Vás žádáme o výbìr snídanì a o sdìlení hodiny, na kterou ji budete chtít pøinést.\r\n\r\nNapsat nám to mùžete do objednávky v kolonce poznámky, nebo zavolat telefonem.";
    public static string CZsvickyButton = "Prosíme o používání výhradnì našich svíèek na místech, kde jsou umístìny.\r\n\r\nZákaz používání vlastních svíèek uvnitø apartmánu. \r\nDìkujeme za pochopení. ";


    public static string ENvButton = "You can fill or drain the hot tub at any time by pressing the green button with the tap symbol.\r\nThe hot tub will automatically drain itself after 90 minutes of operation.\r\n\r\nStop draining - press the green button with the tap lightly - the light must flash - the hot tub is filling Draining the whirlpool - the green light with the tap symbol is permanently lit.\r\n\r\nThe other buttons outside the light have the same mode.\r\n\r\nWhen the lights on the buttons flash - the bubble massage is started. When the lights on the buttons are permanently lit - nothing happens.";
    public static string ENpayButton = "To make a payment, kindly access the \"pay\" tab located at the top left corner of your tablet.\r\nOnce there, you can conveniently settle your bill using either your credit card or mobile phone. \r\nTo use the mobile payment option, simply scan the QR code displayed on your tablet using your mobile phone camera or QR code reader. \r\nThis will direct you to a secure link where you can complete the payment process with ease. \r\nAdditionally, we accept payments via Apple Pay and Google Pay for your added convenience.\r\n\r\nShould you prefer to pay in person, we also offer the option of settling your bill with cash or by card at our reception.";
    public static string ENwifiButton = "Network name: You&Me_host\r\nPassword: Wellnessrezort";
    public static string ENgrillButton = "Let the grill get hot before using.\r\n\r\nClose the grill after use, it must not get rained on.\r\n\r\nThank you.";
    public static string ENkavaButton = "For the use of the coffee machine:\r\n\r\n\r\n1.\r\nFill the water container. The coffee machine must not run without water.\r\n\r\n2.\r\nInsert the capsule into the holder and close it.\r\n\r\n3.\r\nUse the dial to adjust the cup size, and press the cup button to start the coffee machine. Press the button again to stop the coffee machine.\r\n\r\n\r\n\r\nLatté and cappuccino are prepared using two capsules. First, insert the white cup, and then the brown one.";
    public static string ENkoloButton = "In case you are interested, you can rent and try our RockMachine electric bikes. \r\nPrice for a one-day rental of 1 bike:\r\n1 000 Kè";
    public static string ENguestCardButton = "We kindly ask you to fill out the \"Guest Registration Card\", which we are required by law to present to every guest staying overnight. \r\nYou can leave the registration cards in the apartment, and we will collect them upon the completion of your stay.";
    public static string ENpyroButton = "Dear guests,\r\n\r\nplease do not use any pyrotechnics in our resort.\r\n\r\nThe whole resort is wooden.\r\n\r\nBe mindful of our deer and does";
    public static string ENsnidaneButton = "Upon arrival, we kindly request that you select your breakfast preferences and inform us of the desired delivery time.\r\n\r\nYou can either write this information in the notes section of your order or contact us by phone.";
    public static string ENsvickyButton = "Please use exclusively our candles and only in the designated areas.\r\n\r\nIt is prohibited to use any other candles inside the apartment.\r\nThank you for your understanding. ";


    public static string DEvButton = "Sie können den Whirlpool jederzeit füllen oder entleeren, indem Sie die grüne Taste mit dem Hahnsymbol drücken.\r\nDer Whirlpool entleert sich nach 90 Minuten Betrieb automatisch.\r\n\r\nEntleerung stoppen - die grüne Taste mit dem Wasserhahn leicht drücken - die Leuchte muss blinken - der Whirlpool füllt sich - die grüne Leuchte mit dem Wasserhahnsymbol leuchtet dauerhaft.\r\n\r\nDie anderen Tasten außerhalb des Lichts haben den gleichen Modus.\r\n\r\nWenn die Lichter auf den Tasten blinken - die Sprudelmassage wird gestartet. Wenn die Lichter auf den Tasten dauerhaft leuchten - passiert nichts.";
    public static string DEpayButton = "Um eine Zahlung vorzunehmen, rufen Sie bitte die Registerkarte \"Bezahlen\" in der oberen linken Ecke Ihres Tablets auf.\r\nDort können Sie Ihre Rechnung bequem mit Ihrer Kreditkarte oder Ihrem Mobiltelefon begleichen. \r\nUm die mobile Zahlungsoption zu nutzen, scannen Sie einfach den auf Ihrem Tablet angezeigten QR-Code mit der Kamera Ihres Mobiltelefons oder einem QR-Code-Lesegerät. \r\nDies führt Sie zu einem sicheren Link, über den Sie den Zahlungsvorgang ganz einfach abschließen können. \r\nAußerdem akzeptieren wir Zahlungen über Apple Pay und Google Pay, um Ihnen zusätzlichen Komfort zu bieten.\r\n\r\nSollten Sie es vorziehen, persönlich zu bezahlen, bieten wir Ihnen auch die Möglichkeit, Ihre Rechnung mit Bargeld oder mit Karte an unserer Rezeption zu begleichen. ";
    public static string DEwifiButton = "Name des Netzes: You&Me_host\r\nPasswort: Wellnessrezort";
    public static string DEgrillButton = "Lassen Sie den Grill vor dem Gebrauch heiß werden.\r\n\r\nSchließen Sie den Grill nach Gebrauch, er darf nicht nass werden.\r\n\r\nWir danken Ihnen. ";
    public static string DEkavaButton = "Für die Verwendung der Kaffeemaschine:\r\n\r\n\r\n1.\r\nFüllen Sie den Wasserbehälter. Die Kaffeemaschine darf nicht ohne Wasser laufen.\r\n\r\n2.\r\nLegen Sie die Kapsel in den Halter ein und schließen Sie ihn.\r\n\r\n3.\r\nVerwenden Sie das Rad, um die Tassengröße einzustellen, und drücken Sie die Tassen-Taste, um die Kaffeemaschine zu starten. Drücken Sie die Taste erneut, um die Kaffeemaschine anzuhalten.\r\n\r\n\r\n\r\nLatté und Cappuccino werden mit zwei Kapseln zubereitet. Legen Sie zuerst den weißen Becher ein und dann den braunen.";
    public static string DEkoloButton = "Falls Sie Interesse haben, können Sie unsere RockMachine Elektrofahrräder mieten und ausprobieren.\r\nPreis für eine Tagesmiete von 1 Fahrrad:\r\n1 000 Kè";
    public static string DEguestCardButton = "Sehr geehrte Kunden,\r\n\r\nWir bitten Sie freundlich, das \"Gästeregistrierungsformular\" auszufüllen, das wir gesetzlich verpflichtet sind, jedem Übernachtungsgast vorzulegen. \r\nSie können die Registrierungskarten in der Wohnung lassen, und wir werden sie nach Abschluss Ihres Aufenthalts abholen.";
    public static string DEpyroButton = "Liebe Gäste,\r\n\r\nwir bitten Sie, unsere Anlage nicht zu benutzen keine Pyrotechnik in unserem Resort.\r\n\r\nDie ganze Anlage ist aus Holz.\r\n\r\nAchten Sie auf unsere Seile und Hirsche.";
    public static string DEsnidaneButton = "Bei Ihrer Ankunft bitten wir Sie höflich, Ihre Frühstückswünsche auszuwählen und uns die gewünschte Lieferzeit mitzuteilen.\r\n\r\nSie können diese Informationen entweder im Notizenfeld Ihrer Bestellung vermerken oder uns telefonisch kontaktieren.";
    public static string DEsvickyButton = "Bitte verwenden Sie ausschließlich unsere Kerzen und nur an den dafür vorgesehenen Stellen.\r\nDas Verwenden von eigenen Kerzen innerhalb der Wohnung ist untersagt.\r\nVielen Dank für Ihr Verständnis. ";




    private void Start()
    {
        Debug.LogWarning(czBrowser);

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
        yield return new WaitForSeconds(4);
        browserPanel.SetActive(false);
        
    }
    public void HomeButton()
    {


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
        }
    }

}
