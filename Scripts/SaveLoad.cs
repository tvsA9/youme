using System.Collections.Generic;
using UnityEngine;


public class SaveLoad : MonoBehaviour
{
    public void SaveData()
    {
        #region testttt textPrefs
        PlayerPrefs.SetString("CZvButton", testttt.CZvButton);
        PlayerPrefs.SetString("ENvButton", testttt.ENvButton);
        PlayerPrefs.SetString("DEvButton", testttt.DEvButton);

        PlayerPrefs.SetString("CZpayButton", testttt.CZpayButton);
        PlayerPrefs.SetString("ENpayButton", testttt.ENpayButton);
        PlayerPrefs.SetString("DEpayButton", testttt.DEpayButton);

        PlayerPrefs.SetString("CZwifiButton", testttt.CZwifiButton);
        PlayerPrefs.SetString("ENwifiButton", testttt.ENwifiButton);
        PlayerPrefs.SetString("DEwifiButton", testttt.DEwifiButton);

        PlayerPrefs.SetString("CZgrillButton", testttt.CZgrillButton);
        PlayerPrefs.SetString("ENgrillButton", testttt.ENgrillButton);
        PlayerPrefs.SetString("DEgrillButton", testttt.DEgrillButton);

        PlayerPrefs.SetString("CZkavaButton", testttt.CZkavaButton);
        PlayerPrefs.SetString("ENkavaButton", testttt.ENkavaButton);
        PlayerPrefs.SetString("DEkavaButton", testttt.DEkavaButton);

        PlayerPrefs.SetString("CZkoloButton", testttt.CZkoloButton);
        PlayerPrefs.SetString("ENkoloButton", testttt.ENkoloButton);
        PlayerPrefs.SetString("DEkoloButton", testttt.DEkoloButton);

        PlayerPrefs.SetString("CZguestCardButton", testttt.CZguestCardButton);
        PlayerPrefs.SetString("ENguestCardButton", testttt.ENguestCardButton);
        PlayerPrefs.SetString("DEguestCardButton", testttt.DEguestCardButton);

        PlayerPrefs.SetString("CZpyroButton", testttt.CZpyroButton);
        PlayerPrefs.SetString("ENpyroButton", testttt.ENpyroButton);
        PlayerPrefs.SetString("DEpyroButton", testttt.DEpyroButton);

        PlayerPrefs.SetString("CZsnidaneButton", testttt.CZsnidaneButton);
        PlayerPrefs.SetString("ENsnidaneButton", testttt.ENsnidaneButton);
        PlayerPrefs.SetString("DEsnidaneButton", testttt.DEsnidaneButton);

        PlayerPrefs.SetString("CZsvickyButton", testttt.CZsvickyButton);
        PlayerPrefs.SetString("ENsvickyButton", testttt.ENsvickyButton);
        PlayerPrefs.SetString("DEsvickyButton", testttt.DEsvickyButton);
        #endregion

        #region EditPage newsPrefs
        PlayerPrefs.SetString("CZnews1", EditPage.CZnews1);
        PlayerPrefs.SetString("ENnews1", EditPage.ENnews1);
        PlayerPrefs.SetString("DEnews1", EditPage.DEnews1);

        PlayerPrefs.SetString("CZnews2", EditPage.CZnews2);
        PlayerPrefs.SetString("ENnews2", EditPage.ENnews2);
        PlayerPrefs.SetString("DEnews2", EditPage.DEnews2);

        #endregion
    }



    private void Start()
    {
        #region testttt Texts
        if (PlayerPrefs.HasKey("CZvButton"))
        {
            testttt.CZvButton = PlayerPrefs.GetString("CZvButton");
        }
        if (PlayerPrefs.HasKey("ENvButton"))
        {
            testttt.ENvButton = PlayerPrefs.GetString("ENvButton");
        }
        if (PlayerPrefs.HasKey("DEvButton"))
        {
            testttt.DEvButton = PlayerPrefs.GetString("DEvButton");
        }


        if (PlayerPrefs.HasKey("CZpayButton"))
        {
            testttt.CZpayButton = PlayerPrefs.GetString("CZpayButton");
        }
        if (PlayerPrefs.HasKey("ENpayButton"))
        {
            testttt.ENpayButton = PlayerPrefs.GetString("ENpayButton");
        }
        if (PlayerPrefs.HasKey("DEpayButton"))
        {
            testttt.DEpayButton = PlayerPrefs.GetString("DEpayButton");
        }


        if (PlayerPrefs.HasKey("CZwifiButton"))
        {
            testttt.CZwifiButton = PlayerPrefs.GetString("CZwifiButton");
        }
        if (PlayerPrefs.HasKey("ENwifiButton"))
        {
            testttt.ENwifiButton = PlayerPrefs.GetString("ENwifiButton");
        }
        if (PlayerPrefs.HasKey("DEwifiButton"))
        {
            testttt.DEwifiButton = PlayerPrefs.GetString("DEwifiButton");
        }


        if (PlayerPrefs.HasKey("CZgrillButton"))
        {
            testttt.CZgrillButton = PlayerPrefs.GetString("CZgrillButton");
        }
        if (PlayerPrefs.HasKey("ENgrillButton"))
        {
            testttt.ENgrillButton = PlayerPrefs.GetString("ENgrillButton");
        }
        if (PlayerPrefs.HasKey("DEgrillButton"))
        {
            testttt.DEgrillButton = PlayerPrefs.GetString("DEgrillButton");
        }


        if (PlayerPrefs.HasKey("CZkavaButton"))
        {
            testttt.CZkavaButton = PlayerPrefs.GetString("CZkavaButton");
        }
        if (PlayerPrefs.HasKey("ENkavaButton"))
        {
            testttt.ENkavaButton = PlayerPrefs.GetString("ENkavaButton");
        }
        if (PlayerPrefs.HasKey("DEkavaButton"))
        {
            testttt.DEkavaButton = PlayerPrefs.GetString("DEkavaButton");
        }


        if (PlayerPrefs.HasKey("CZkoloButton"))
        {
            testttt.CZkoloButton = PlayerPrefs.GetString("CZkoloButton");
        }
        if (PlayerPrefs.HasKey("ENkoloButton"))
        {
            testttt.ENkoloButton = PlayerPrefs.GetString("ENkoloButton");
        }
        if (PlayerPrefs.HasKey("DEkoloButton"))
        {
            testttt.DEkoloButton = PlayerPrefs.GetString("DEkoloButton");
        }


        if (PlayerPrefs.HasKey("CZguestCardButton"))
        {
            testttt.CZguestCardButton = PlayerPrefs.GetString("CZguestCardButton");
        }
        if (PlayerPrefs.HasKey("ENguestCardButton"))
        {
            testttt.ENguestCardButton = PlayerPrefs.GetString("ENguestCardButton");
        }
        if (PlayerPrefs.HasKey("DEguestCardButton"))
        {
            testttt.DEguestCardButton = PlayerPrefs.GetString("DEguestCardButton");
        }


        if (PlayerPrefs.HasKey("CZpyroButton"))
        {
            testttt.CZpyroButton = PlayerPrefs.GetString("CZpyroButton");
        }
        if (PlayerPrefs.HasKey("ENpyroButton"))
        {
            testttt.ENpyroButton = PlayerPrefs.GetString("ENpyroButton");
        }
        if (PlayerPrefs.HasKey("DEpyroButton"))
        {
            testttt.DEpyroButton = PlayerPrefs.GetString("DEpyroButton");
        }


        if (PlayerPrefs.HasKey("CZsnidaneButton"))
        {
            testttt.CZsnidaneButton = PlayerPrefs.GetString("CZsnidaneButton");
        }
        if (PlayerPrefs.HasKey("ENsnidaneButton"))
        {
            testttt.ENsnidaneButton = PlayerPrefs.GetString("ENsnidaneButton");
        }
        if (PlayerPrefs.HasKey("DEsnidaneButton"))
        {
            testttt.DEsnidaneButton = PlayerPrefs.GetString("DEsnidaneButton");
        }


        if (PlayerPrefs.HasKey("CZsvickyButton"))
        {
            testttt.CZsvickyButton = PlayerPrefs.GetString("CZsvickyButton");
        }
        if (PlayerPrefs.HasKey("ENsvickyButton"))
        {
            testttt.ENsvickyButton = PlayerPrefs.GetString("ENsvickyButton");
        }
        if (PlayerPrefs.HasKey("DEsvickyButton"))
        {
            testttt.DEsvickyButton = PlayerPrefs.GetString("DEsvickyButton");
        }
        #endregion

        #region EditPage News
        if (PlayerPrefs.HasKey("CZnews1"))
        {
            EditPage.CZnews1 = PlayerPrefs.GetString("CZnews1");
        }
        if (PlayerPrefs.HasKey("ENnews1"))
        {
            EditPage.ENnews1 = PlayerPrefs.GetString("ENnews1");
        }
        if (PlayerPrefs.HasKey("DEnews1"))
        {
            EditPage.DEnews1 = PlayerPrefs.GetString("DEnews1");
        }


        if (PlayerPrefs.HasKey("CZnews2"))
        {
            EditPage.CZnews2 = PlayerPrefs.GetString("CZnews2");
        }
        if (PlayerPrefs.HasKey("ENnews2"))
        {
            EditPage.ENnews2 = PlayerPrefs.GetString("ENnews2");
        }
        if (PlayerPrefs.HasKey("DEnews2"))
        {
            EditPage.DEnews2 = PlayerPrefs.GetString("DEnews2");
        }


        #endregion
    }




    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
