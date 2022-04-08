using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    public static ButtonsManager instance;
    public delegate void ButtonManagerDelegate();
    public delegate void ButtonManagerDelegate2(int SkinID);

    public static event ButtonManagerDelegate ChangeMoney;
    public static event ButtonManagerDelegate2 ChangeSkin;
    public GameObject ShopPanel;
    public GameObject GameManager;

   public int NormalSkinPrice = 100;
    public int AdvancedSkinPrice = 1000;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RetryButton()
    {
        
        SceneManager.LoadScene(1);
    }
    public void HomePageButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowAndHideShopPanel()
    {
        if (ShopPanel.active == false)
            ShopPanel.SetActive(true);
        else
            ShopPanel.SetActive(false);
    }
    

    public void Skin0()

    {
        int SkinID = 0;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID,NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= NormalSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }
            
        }

     

    }

    public void Skin1()
    {
        int SkinID = 1;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= NormalSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }

        }

    }

    public void Skin2()
    {
        int SkinID = 2;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= NormalSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }

        }

    }

    public void Skin3()
    {
        int SkinID = 3;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= NormalSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }

        }

    }

    public void Skin4()
    {
        int SkinID = 4;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= NormalSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }

        }

    }

    public void Skin5()
    {
        int SkinID = 5;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= NormalSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }

        }

    }

    public void Skin6()
    {
        int SkinID = 6;
        
        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, AdvancedSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= AdvancedSkinPrice)
            {
                OpenSkin(SkinID, AdvancedSkinPrice);
            }

        }

    }

    public void Skin7()
    {
        int SkinID = 7;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == true)
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= AdvancedSkinPrice)
            {
                OpenSkin(SkinID, AdvancedSkinPrice);
            }

        }

    }

    public void Skin8()
    {
        int SkinID = 8;

        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] )
        {
            OpenSkin(SkinID, NormalSkinPrice);
        }
        else
        {
            if (GameManager.GetComponent<GameManager>().mony >= AdvancedSkinPrice)
            {
                OpenSkin(SkinID, NormalSkinPrice);
            }

        }
    }



    public void OpenSkin(int SkinID , int price)
    {
      
        
        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] == false)
        {
            GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID] = true;
            GameManager.GetComponent<GameManager>().mony -= price;
            ChangeMoney();
        }
        GameManager.GetComponent<GameManager>().CaruentSkinNumber = SkinID;
        GameManager.GetComponent<GameManager>().CuruentSkin = GameManager.GetComponent<GameManager>().skins[GameManager.GetComponent<GameManager>().CaruentSkinNumber];
        ChangeSkin(SkinID);
        SaveSystem.SaveData(GameManager.GetComponent<GameManager>());
    }


}
