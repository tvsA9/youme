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
    public string czBrowser = "Pro aktu�ln� menu a objedn�vky, pou�ijte druhou ikonu na plo�e: Vivaldi Browser. D�kujeme.";
    public string enBrowser = "For the current menu and orders, use the second icon on the desktop: Vivaldi Browser. Thank you.";
    public string deBrowser = "F�r das aktuelle Men� und Bestellungen verwenden Sie das zweite Symbol auf dem Desktop: Vivaldi Browser. Vielen Dank.";

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

    public static string CZvButton = "V��ivku si m��ete kdykoliv napustit nebo vypustit stiskem zelen�ho tla��tka se symbolem kohoutku.\r\nV��ivka se automaticky po 90 minut�ch provozu za�ne sama vypou�t�t.\r\n\r\nZastavit vypou�t�n� � stiskn�te lehce zelen� tla��tko s kohoutkem � sv�tlo mus� blikat � v��ivka se napou�t� Vypou�t�n� v��ivky � zelen� sv�tlo se symbolem kohoutku sv�t� trvale.\r\nStejn� re�im maj� i ostatn� tla��tka mimo sv�tla.\r\n\r\nKdy� sv�t�lka na tla��tk�ch blikaj� � bublinka mas� je spu�t�na. Kdy� sv�t�lka na tla��tk�ch trvale sv�t� � ned�je se nic.";
    public static string CZpayButton = "Va�i �tratu m�te mo�nost uhradit p��mo v tabletu v z�lo�ce ,,Zaplatit�� (vlevo naho�e).\r\nJe mo�n� prov�st �hradu platebn� kartou nebo p�es mobiln� telefon p�es QR k�d, kter� naskenujete fotoapar�tem (nebo �te�kou QR k�d�).\r\nD�le je mo�n� zaplatit p�es Apple Pay a Google Pay.\r\n\r\nP��padn� i hotov� nebo kartou na recepci.";
    public static string CZwifiButton = "N�zev s�t�: You&Me_host\r\n\r\nHeslo: Wellnessrezort";
    public static string CZgrillButton = "P�ed pou�it�m nechte grill po��dn� rozp�lit.\r\n\r\nPros�me po pou�it� grill zav��t, nesm� do n�j napr�et.\r\n\r\nD�kujeme.";
    public static string CZkavaButton = "Pro pou�it� k�vovaru:\r\n\r\n\r\n1.\r\nNapl�te n�dobu na vodu. K�vovar nesm� b�et bez vody.\r\n\r\n2.\r\nVlo�te kapsli do z�sobn�ku a zav�ete.\r\n\r\n3.\r\nKole�kem si nastav�te velikost ��lku a stisknut�m tla��tka ��lku spust�te k�vovar, op�tovn�m stiskem k�vovar zastav�.\r\n\r\n\r\n\r\nLatt� a cappuccino se p�ipravuje ze dvou kapsl�, nejprve vlo�te b�l� kel�mek, pot� hn�d�.";
    public static string CZkoloButton = "V p��pad� z�jmu si m��ete vyp�j�it a vyzkou�et elektrokolo RockMachine.\r\n\r\nCena za denn� pron�jem:\r\n1 000 K�";
    public static string CZguestCardButton = "V�en� host�,\r\n\r\npros�me V�s o vypln�n� ,,Registra�n� karty hosta��, kterou jsme ze z�kona povinni p�edlo�it ka�d�mu ubytovan�mu hostu na noc. \r\nRegistra�n� karty m��ete nechat v apartm�nu, po ukon�en� va�eho pobytu si je vyzvedneme.";
    public static string CZpyroButton = "V�en� host�,\r\n\r\npros�me, abyste nepou��vali v na�em resortu ��dnou pyrotechniku.\r\n\r\nCel� resort je d�ev�n�.\r\n\r\nBerte ohled na na�e lan� a jelena";
    public static string CZsnidaneButton = "Po p��jezdu V�s ��d�me o v�b�r sn�dan� a o sd�len� hodiny, na kterou ji budete cht�t p�in�st.\r\n\r\nNapsat n�m to m��ete do objedn�vky v kolonce pozn�mky, nebo zavolat telefonem.";
    public static string CZsvickyButton = "Pros�me o pou��v�n� v�hradn� na�ich sv��ek na m�stech, kde jsou um�st�ny.\r\n\r\nZ�kaz pou��v�n� vlastn�ch sv��ek uvnit� apartm�nu. \r\nD�kujeme za pochopen�. ";


    public static string ENvButton = "You can fill or drain the hot tub at any time by pressing the green button with the tap symbol.\r\nThe hot tub will automatically drain itself after 90 minutes of operation.\r\n\r\nStop draining - press the green button with the tap lightly - the light must flash - the hot tub is filling Draining the whirlpool - the green light with the tap symbol is permanently lit.\r\n\r\nThe other buttons outside the light have the same mode.\r\n\r\nWhen the lights on the buttons flash - the bubble massage is started. When the lights on the buttons are permanently lit - nothing happens.";
    public static string ENpayButton = "To make a payment, kindly access the \"pay\" tab located at the top left corner of your tablet.\r\nOnce there, you can conveniently settle your bill using either your credit card or mobile phone. \r\nTo use the mobile payment option, simply scan the QR code displayed on your tablet using your mobile phone camera or QR code reader. \r\nThis will direct you to a secure link where you can complete the payment process with ease. \r\nAdditionally, we accept payments via Apple Pay and Google Pay for your added convenience.\r\n\r\nShould you prefer to pay in person, we also offer the option of settling your bill with cash or by card at our reception.";
    public static string ENwifiButton = "Network name: You&Me_host\r\nPassword: Wellnessrezort";
    public static string ENgrillButton = "Let the grill get hot before using.\r\n\r\nClose the grill after use, it must not get rained on.\r\n\r\nThank you.";
    public static string ENkavaButton = "For the use of the coffee machine:\r\n\r\n\r\n1.\r\nFill the water container. The coffee machine must not run without water.\r\n\r\n2.\r\nInsert the capsule into the holder and close it.\r\n\r\n3.\r\nUse the dial to adjust the cup size, and press the cup button to start the coffee machine. Press the button again to stop the coffee machine.\r\n\r\n\r\n\r\nLatt� and cappuccino are prepared using two capsules. First, insert the white cup, and then the brown one.";
    public static string ENkoloButton = "In case you are interested, you can rent and try our RockMachine electric bikes. \r\nPrice for a one-day rental of 1 bike:\r\n1 000 K�";
    public static string ENguestCardButton = "We kindly ask you to fill out the \"Guest Registration Card\", which we are required by law to present to every guest staying overnight. \r\nYou can leave the registration cards in the apartment, and we will collect them upon the completion of your stay.";
    public static string ENpyroButton = "Dear guests,\r\n\r\nplease do not use any pyrotechnics in our resort.\r\n\r\nThe whole resort is wooden.\r\n\r\nBe mindful of our deer and does";
    public static string ENsnidaneButton = "Upon arrival, we kindly request that you select your breakfast preferences and inform us of the desired delivery time.\r\n\r\nYou can either write this information in the notes section of your order or contact us by phone.";
    public static string ENsvickyButton = "Please use exclusively our candles and only in the designated areas.\r\n\r\nIt is prohibited to use any other candles inside the apartment.\r\nThank you for your understanding. ";


    public static string DEvButton = "Sie k�nnen den Whirlpool jederzeit f�llen oder entleeren, indem Sie die gr�ne Taste mit dem Hahnsymbol dr�cken.\r\nDer Whirlpool entleert sich nach 90 Minuten Betrieb automatisch.\r\n\r\nEntleerung stoppen - die gr�ne Taste mit dem Wasserhahn leicht dr�cken - die Leuchte muss blinken - der Whirlpool f�llt sich - die gr�ne Leuchte mit dem Wasserhahnsymbol leuchtet dauerhaft.\r\n\r\nDie anderen Tasten au�erhalb des Lichts haben den gleichen Modus.\r\n\r\nWenn die Lichter auf den Tasten blinken - die Sprudelmassage wird gestartet. Wenn die Lichter auf den Tasten dauerhaft leuchten - passiert nichts.";
    public static string DEpayButton = "Um eine Zahlung vorzunehmen, rufen Sie bitte die Registerkarte \"Bezahlen\" in der oberen linken Ecke Ihres Tablets auf.\r\nDort k�nnen Sie Ihre Rechnung bequem mit Ihrer Kreditkarte oder Ihrem Mobiltelefon begleichen. \r\nUm die mobile Zahlungsoption zu nutzen, scannen Sie einfach den auf Ihrem Tablet angezeigten QR-Code mit der Kamera Ihres Mobiltelefons oder einem QR-Code-Leseger�t. \r\nDies f�hrt Sie zu einem sicheren Link, �ber den Sie den Zahlungsvorgang ganz einfach abschlie�en k�nnen. \r\nAu�erdem akzeptieren wir Zahlungen �ber Apple Pay und Google Pay, um Ihnen zus�tzlichen Komfort zu bieten.\r\n\r\nSollten Sie es vorziehen, pers�nlich zu bezahlen, bieten wir Ihnen auch die M�glichkeit, Ihre Rechnung mit Bargeld oder mit Karte an unserer Rezeption zu begleichen. ";
    public static string DEwifiButton = "Name des Netzes: You&Me_host\r\nPasswort: Wellnessrezort";
    public static string DEgrillButton = "Lassen Sie den Grill vor dem Gebrauch hei� werden.\r\n\r\nSchlie�en Sie den Grill nach Gebrauch, er darf nicht nass werden.\r\n\r\nWir danken Ihnen. ";
    public static string DEkavaButton = "F�r die Verwendung der Kaffeemaschine:\r\n\r\n\r\n1.\r\nF�llen Sie den Wasserbeh�lter. Die Kaffeemaschine darf nicht ohne Wasser laufen.\r\n\r\n2.\r\nLegen Sie die Kapsel in den Halter ein und schlie�en Sie ihn.\r\n\r\n3.\r\nVerwenden Sie das Rad, um die Tassengr��e einzustellen, und dr�cken Sie die Tassen-Taste, um die Kaffeemaschine zu starten. Dr�cken Sie die Taste erneut, um die Kaffeemaschine anzuhalten.\r\n\r\n\r\n\r\nLatt� und Cappuccino werden mit zwei Kapseln zubereitet. Legen Sie zuerst den wei�en Becher ein und dann den braunen.";
    public static string DEkoloButton = "Falls Sie Interesse haben, k�nnen Sie unsere RockMachine Elektrofahrr�der mieten und ausprobieren.\r\nPreis f�r eine Tagesmiete von 1 Fahrrad:\r\n1 000 K�";
    public static string DEguestCardButton = "Sehr geehrte Kunden,\r\n\r\nWir bitten Sie freundlich, das \"G�steregistrierungsformular\" auszuf�llen, das wir gesetzlich verpflichtet sind, jedem �bernachtungsgast vorzulegen. \r\nSie k�nnen die Registrierungskarten in der Wohnung lassen, und wir werden sie nach Abschluss Ihres Aufenthalts abholen.";
    public static string DEpyroButton = "Liebe G�ste,\r\n\r\nwir bitten Sie, unsere Anlage nicht zu benutzen keine Pyrotechnik in unserem Resort.\r\n\r\nDie ganze Anlage ist aus Holz.\r\n\r\nAchten Sie auf unsere Seile und Hirsche.";
    public static string DEsnidaneButton = "Bei Ihrer Ankunft bitten wir Sie h�flich, Ihre Fr�hst�cksw�nsche auszuw�hlen und uns die gew�nschte Lieferzeit mitzuteilen.\r\n\r\nSie k�nnen diese Informationen entweder im Notizenfeld Ihrer Bestellung vermerken oder uns telefonisch kontaktieren.";
    public static string DEsvickyButton = "Bitte verwenden Sie ausschlie�lich unsere Kerzen und nur an den daf�r vorgesehenen Stellen.\r\nDas Verwenden von eigenen Kerzen innerhalb der Wohnung ist untersagt.\r\nVielen Dank f�r Ihr Verst�ndnis. ";




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
