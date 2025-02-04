using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject anim;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {

            if (testttt.mIsOn)
            {
                menuPanel.GetComponent<Animation>().Play("menuChoose");
                testttt.mIsOn = false;
            }
            if (testttt.vIsOn)
            {
                anim.GetComponent<Animation>().Play("VirivkaAnimRev");
                testttt.svickyBool = false;
                Toggles1.saunaBool = false;
                testttt.vBool = false;
                testttt.wifiBool = false;
                testttt.grillBool = false;
                testttt.kavaBool = false;
                testttt.koloBool = false;
                testttt.guestCardBool = false;
                testttt.pyroBool = false;
                testttt.snidaneBool = false;
                testttt.payBool = false;
                testttt.vIsOn = false;
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
        Debug.LogWarning("App Quit");
    }

}
