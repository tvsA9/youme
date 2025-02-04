using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject virivkaPanel;
    public GameObject saunaPanel;
    public GameObject menuPanel;

    public static bool mIsOn = false;
    public bool vIsOn = false;
    public bool sIsOn = false;





    #region Virivka open Panel

    public void ButtonV()
    {
        if (sIsOn)
        {
            ButtonClose();
            virivkaPanel.GetComponent<Animation>().Play("VirivkaAnim");
            vIsOn = true;
        }
        else
        {
            if (vIsOn == false)
            {
                virivkaPanel.GetComponent<Animation>().Play("VirivkaAnim");
                vIsOn = true;
            }
            else
            {
                ButtonClose();
            }
        }

        menuPanel.GetComponent<Animation>().Play("menuChoose");
        mIsOn = false;
    }

    #endregion

    #region Sauna open Panenl

    public void ButtonS()
    {
        if (vIsOn)
        {
            ButtonClose();
            saunaPanel.GetComponent<Animation>().Play("VirivkaAnim");
            sIsOn = true;
        }
        else
        {
            if (sIsOn == false)
            {
                saunaPanel.GetComponent<Animation>().Play("VirivkaAnim");
                sIsOn = true;
            }
            else
            {
            ButtonClose();
            }

        }

        menuPanel.GetComponent<Animation>().Play("menuChoose");
        mIsOn = false;
    }

    #endregion

    #region EverythingClose
    public void ButtonClose()
    {
        if (vIsOn)
        {
            virivkaPanel.GetComponent<Animation>().Play("VirivkaAnimRev");
            vIsOn = false;
        }
        if (sIsOn)
        {
            saunaPanel.GetComponent<Animation>().Play("VirivkaAnimRev");
            sIsOn = false;
        }
    }
    #endregion

    #region Click to get food

    public void ButtonLink()
    {
        Application.OpenURL(Languages.currentLink);
        menuPanel.GetComponent<Animation>().Play("menuChooseRev");
        mIsOn = false;

    }

    #endregion

    #region Open menu with buttons
    public void ButtonMenu()
    {
        if (mIsOn == false)
        {
            menuPanel.GetComponent<Animation>().Play("menuChooseRev");
            mIsOn = true;
        }
        else
        {
            menuPanel.GetComponent<Animation>().Play("menuChoose");
            mIsOn= false;
        }

    }

    #endregion

    #region Backplate to close menu
    public void CloseMenu()
    {
        if (mIsOn == true)
        {
        menuPanel.GetComponent<Animation>().Play("menuChoose");
        mIsOn = false;
        }

    }
    #endregion


}
