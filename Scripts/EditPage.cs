using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EditPage : MonoBehaviour
{
    public int adminPageCount;
    public GameObject adminPage;

    public GameObject blockExit1;
    public GameObject blockExit2;


    public TMP_InputField inputField;
    public GameObject savePanel;
    public GameObject ddObject;
    public int ddIndex;
    public string input;
    public Button editPanelShow;
    public bool pinInputShowing = false;

    public int buttonClickCount;

    public GameObject inputShow;
    public TMP_InputField passwordField;
    public GameObject editPage;
    public GameObject exitButton;
    public GameObject exitButton1;

    public GameObject firstPanel;
    public GameObject secondPanel;

    public TMP_Dropdown newsDD;
    public TMP_InputField newsInput;
    public int index;
    public string nInput;
    public GameObject nsavePanel;
    public GameObject nddObject;


    public TMP_Text newsText1;
    public TMP_Text newsText2;
    public TMP_Text newsText3;

    public GameObject newsPanel1;
    public GameObject newsPanel2;
    public GameObject newsPanel3;

    public static string CZnews1 = "";
    public static string CZnews2 = "";
    public static string CZnews3 = "Po pøíjezdu Vás žádáme o výbìr snídanì a o sdìlení hodiny, na kterou ji budete chtít pøinést. \r\nNapsat nám to mùžete do objednávky v kolonce poznámky, nebo zavolat telefonem.";

    public static string ENnews1 = "";
    public static string ENnews2 = "";
    public static string ENnews3 = "Upon arrival, we kindly request that you select your breakfast preferences and inform us of the desired delivery time. \r\nYou can either write this information in the notes section of your order or contact us by phone.";

    public static string DEnews1 = "";
    public static string DEnews2 = "";
    public static string DEnews3 = "Bei Ihrer Ankunft bitten wir Sie höflich, Ihre Frühstückswünsche auszuwählen und uns die gewünschte Lieferzeit mitzuteilen. \r\nSie können diese Informationen entweder im Notizenfeld Ihrer Bestellung vermerken oder uns telefonisch kontaktieren.";




    private void Update()
    {
        if(CZnews1 == "")
        {
            newsPanel1.SetActive(false);
        }
        else
        {
            newsPanel1.SetActive(true);
        }
        if (CZnews2 == "")
        {
            newsPanel2.SetActive(false);
        }
        else
        {
            newsPanel2.SetActive(true);
        }
        if (CZnews3 == "")
        {
            newsPanel3.SetActive(false);
        }
        else
        {
            newsPanel3.SetActive(true);
        }



        if (buttonClickCount > 4)
        {
            buttonClickCount = 4;
        }

        switch (Languages.globalLang)
        {
            case 0:
                newsText1.text = CZnews1;
                newsText2.text = CZnews2;
                newsText3.text = CZnews3;
                break;

            case 1:
                newsText1.text = ENnews1;
                newsText2.text = ENnews2;
                newsText3.text = ENnews3;
                break;

            case 2:
                newsText1.text = DEnews1;
                newsText2.text = DEnews2;
                newsText3.text = DEnews3;
                break;
        }
    }

    

    #region 1stPage
    public void OnEditButtonClick()
    {
        if (buttonClickCount == 4)
        {

            inputShow.SetActive(true);
            if (pinInputShowing == false)
            {
                pinInputShowing = true;
                inputShow.SetActive(true);
            }
            else
            {
                pinInputShowing = false;
                inputShow.SetActive(false);
            }
            buttonClickCount = 0;
        }
        else
        {
            buttonClickCount++;
        }



    }
    public void Exit()
    {
        pinInputShowing = false;
        passwordField.text = "";
    }
    public void OnPinEnter()
    {
        if (inputShow.GetComponentInChildren<TMP_InputField>().text == "0258")
        {
            Debug.Log("Correct");
            editPage.SetActive(true);
            inputField.text = testttt.CZvButton;
            newsInput.text = CZnews1;
        }
        else
        {
            Debug.Log("False");
            inputShow.SetActive(false);
            pinInputShowing = false;

        }

        Debug.Log(inputField.text);
        Debug.Log(newsInput.text);
    }

    public void InputRegister(string inputLocal)
    {
        input = inputLocal;
        inputField.text = input;
    }

    private void Start()
    {
        // Initialize the input field text based on the selected dropdown index
        UpdateInputFieldText();
    }

    public void DropDown(int index)
    {
        ddIndex = index;
        // Update the input field text based on the selected dropdown index
        UpdateInputFieldText();
    }

    public void OnEndWriting()
    {
        savePanel.SetActive(true);
        ddObject.SetActive(false);

    }
    public void OnSelectInput()
    {
        blockExit1.SetActive(true);
    }
    public void OnNewsSelectInput()
    {
        blockExit2.SetActive(true);
    }

    public void SaveEdit()
    {
        blockExit1.SetActive(false);


        savePanel.SetActive(false);
        ddObject.SetActive(true);
        string textToSave = inputField.text;
        Debug.Log(textToSave);

        switch (ddIndex)
        {
            case 0:
                testttt.CZvButton = textToSave;
                break;
            case 1:
                testttt.ENvButton = textToSave;
                break;
            case 2:
                testttt.DEvButton = textToSave;
                break;
            case 3:
                testttt.CZpayButton = textToSave;
                break;
            case 4:
                testttt.ENpayButton = textToSave;
                break;
            case 5:
                testttt.DEpayButton = textToSave;
                break;
            case 6:
                testttt.CZwifiButton = textToSave;
                break;
            case 7:
                testttt.ENwifiButton = textToSave;
                break;
            case 8:
                testttt.DEwifiButton = textToSave;
                break;
            case 9:
                testttt.CZgrillButton = textToSave;
                break;
            case 10:
                testttt.ENgrillButton = textToSave;
                break;
            case 11:
                testttt.DEgrillButton = textToSave;
                break;
            case 12:
                testttt.CZkavaButton = textToSave;
                break;
            case 13:
                testttt.ENkavaButton = textToSave;
                break;
            case 14:
                testttt.DEkavaButton = textToSave;
                break;
            case 15:
                testttt.CZkoloButton = textToSave;
                break;
            case 16:
                testttt.ENkoloButton = textToSave;
                break;
            case 17:
                testttt.DEkoloButton = textToSave;
                break;
            case 18:
                testttt.CZguestCardButton = textToSave;
                break;
            case 19:
                testttt.ENguestCardButton = textToSave;
                break;
            case 20:
                testttt.DEguestCardButton = textToSave;
                break;
            case 21:
                testttt.CZpyroButton = textToSave;
                break;
            case 22:
                testttt.ENpyroButton = textToSave;
                break;
            case 23:
                testttt.DEpyroButton = textToSave;
                break;
            case 24:
                testttt.CZsnidaneButton = textToSave;
                break;
            case 25:
                testttt.ENsnidaneButton = textToSave;
                break;
            case 26:
                testttt.DEsnidaneButton = textToSave;
                break;
            case 27:
                testttt.CZsvickyButton = textToSave;
                break;
            case 28:
                testttt.ENsvickyButton = textToSave;
                break;
            case 29:
                testttt.DEsvickyButton = textToSave;
                break;
            case 30:
                Toggles1.czBioSaunaText = textToSave;
                break;
            case 31:
                Toggles1.enBioSaunaText = textToSave;
                break;
            case 32:
                Toggles1.deBioSaunaText = textToSave;
                break;
            case 33:
                Toggles1.czFinParaSaunaText = textToSave;
                break;
            case 34:
                Toggles1.enFinParaSaunaText = textToSave;
                break;
            case 35:
                Toggles1.deFinParaSaunaText = textToSave;
                break;
            case 36:
                Toggles1.czFinSaunaText = textToSave;
                break;
            case 37:
                Toggles1.enFinSaunaText = textToSave;
                break;
            case 38:
                Toggles1.deFinSaunaText = textToSave;
                break;
            case 39:
                Toggles1.czTropSaunaText = textToSave;
                break;
            case 40:
                Toggles1.enTropSaunaText = textToSave;
                break;
            case 41:
                Toggles1.deTropSaunaText = textToSave;
                break;
            case 42:
                Toggles1.czSaltSaunaText = textToSave;
                break;
            case 43:
                Toggles1.enSaltSaunaText = textToSave;
                break;
            case 44:
                Toggles1.deSaltSaunaText = textToSave;
                break;
        }

    }
    
    private void UpdateInputFieldText()
    {
        string buttonText = "";
        switch (ddIndex)
        {
            case 0:
                buttonText = testttt.CZvButton;
                break;
            case 1:
                buttonText = testttt.ENvButton;
                break;
            case 2:
                buttonText = testttt.DEvButton;
                break;
            case 3:
                buttonText = testttt.CZpayButton;
                break;
            case 4:
                buttonText = testttt.ENpayButton;
                break;
            case 5:
                buttonText = testttt.DEpayButton;
                break;
            case 6:
                buttonText = testttt.CZwifiButton;
                break;
            case 7:
                buttonText = testttt.ENwifiButton;
                break;
            case 8:
                buttonText = testttt.DEwifiButton;
                break;
            case 9:
                buttonText = testttt.CZgrillButton;
                break;
            case 10:
                buttonText = testttt.ENgrillButton;
                break;
            case 11:
                buttonText = testttt.DEgrillButton;
                break;
            case 12:
                buttonText = testttt.CZkavaButton;
                break;
            case 13:
                buttonText = testttt.ENkavaButton;
                break;
            case 14:
                buttonText = testttt.DEkavaButton;
                break;
            case 15:
                buttonText = testttt.CZkoloButton;
                break;
            case 16:
                buttonText = testttt.ENkoloButton;
                break;
            case 17:
                buttonText = testttt.DEkoloButton;
                break;
            case 18:
                buttonText = testttt.CZguestCardButton;
                break;
            case 19:
                buttonText = testttt.ENguestCardButton;
                break;
            case 20:
                buttonText = testttt.DEguestCardButton;
                break;
            case 21:
                buttonText = testttt.CZpyroButton;
                break;
            case 22:
                buttonText = testttt.ENpyroButton;
                break;
            case 23:
                buttonText = testttt.DEpyroButton;
                break;
            case 24:
                buttonText = testttt.CZsnidaneButton;
                break;
            case 25:
                buttonText = testttt.ENsnidaneButton;
                break;
            case 26:
                buttonText = testttt.DEsnidaneButton;
                break;
            case 27:
                buttonText = testttt.CZsvickyButton;
                break;
            case 28:
                buttonText = testttt.ENsvickyButton;
                break;
            case 29:
                buttonText = testttt.DEsvickyButton;
                break;
            case 30:
                buttonText = Toggles1.czBioSaunaText;
                break;
            case 31:
                buttonText = Toggles1.enBioSaunaText;
                break;
            case 32:
                buttonText = Toggles1.deBioSaunaText;
                break;
            case 33:
                buttonText = Toggles1.czFinParaSaunaText;
                break;
            case 34:
                buttonText = Toggles1.enFinParaSaunaText;
                break;
            case 35:
                buttonText = Toggles1.deFinParaSaunaText;
                break;
            case 36:
                buttonText = Toggles1.czFinSaunaText;
                break;
            case 37:
                buttonText = Toggles1.enFinSaunaText;
                break;
            case 38:
                buttonText = Toggles1.deFinSaunaText;
                break;
            case 39:
                buttonText = Toggles1.czTropSaunaText;
                break;
            case 40:
                buttonText = Toggles1.enTropSaunaText;
                break;
            case 41:
                buttonText = Toggles1.deTropSaunaText;
                break;
            case 42:
                buttonText = Toggles1.czSaltSaunaText;
                break;
            case 43:
                buttonText = Toggles1.enSaltSaunaText;
                break;
            case 44:
                buttonText = Toggles1.deSaltSaunaText;
                break;


            default:
                Debug.LogWarning("Invalid dropdown index!");
                break;
        }

        inputField.text = buttonText;
    }
    #endregion



    #region 2ndPage

    public void SecondPageButton()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }

    public void FirstPageButton()
    {
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
    }


    public void NewsDropdown(int localIndex)
    {
        index = localIndex;

        NewsInputRead();
    }

    public void NewsInputRegister(string inputLocal)
    {
        nInput = inputLocal;
        newsInput.text = nInput;
    }
    public void NewsInputRead()
    {


        switch (index)
        {
            case 0:
                newsInput.text = CZnews1;
                break;
            case 1:
                newsInput.text = ENnews1;
                break;
            case 2:
                newsInput.text = DEnews1;
                break;
            case 3:
                newsInput.text = CZnews2;
                break;
            case 4:
                newsInput.text = ENnews2;
                break;
            case 5:
                newsInput.text = DEnews2;
                break;
            case 6:
                newsInput.text = CZnews3;
                break;
            case 7:
                newsInput.text = ENnews3;
                break;
            case 8:
                newsInput.text = DEnews3;
                break;


        }
        Debug.Log(index);
    }

    public void OnNewsEndWriting()
    {
        nsavePanel.SetActive(true);
        nddObject.SetActive(false);
    }

    public void NewsSaveEdit()
    {
        nsavePanel.SetActive(false);
        nddObject.SetActive(true);
        blockExit2.SetActive(false);

        string newsText = newsInput.text;

        switch (index)
        {
            case 0:
                CZnews1 = newsText;
                break;
            case 1:
                ENnews1 = newsText;
                break;
            case 2:
                DEnews1 = newsText;
                break;
            case 3:
                CZnews2 = newsText;
                break;
            case 4:
                ENnews2 = newsText;
                break;
            case 5:
                DEnews2 = newsText;
                break;
            case 6:
                CZnews3 = newsText;
                break;
            case 7:
                ENnews3 = newsText;
                break;
            case 8:
                DEnews3 = newsText;
                break;
        }
        Debug.Log(index);
        Debug.Log(newsInput.text);

    }

    #endregion


    public void BackButton1()
    {
        savePanel.SetActive(false);
        ddObject.SetActive(true);
        blockExit1.SetActive(false);


    }

    public void BackButton2()
    {
        nsavePanel.SetActive(false);
        nddObject.SetActive(true);
        blockExit2.SetActive(false);
    }

    public void AdminPageClick()
    {
        if (adminPageCount < 10)
        {
            adminPageCount++;
        }
        else
        {
            adminPage.SetActive(true);
            adminPageCount = 0;
        }
    }
}