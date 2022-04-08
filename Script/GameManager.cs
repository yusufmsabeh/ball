using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void OnGameStart();
    public static event OnGameStart KillThaPlayer;
    public static GameManager instance;


    //Variables
    
    int HighScore=0;
    GameObject Player;
    
    public  Sprite [] skins = new Sprite[10];
    public bool[] IsOpenSkin = new bool[9];
    public int CaruentSkinNumber=9;
    public Sprite CuruentSkin;
    public int mony=0;
    GameObject UIManager;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }

        //KillThaPlayer += ShowDeathPanel;
        //KillThaPlayer += SavingHighScore;
        PlayerData data = SaveSystem.LoadData();
        //make everyskin not aveilable utile we get the data from the device


        for (int i = 0; i > 9; i++)
        {
            IsOpenSkin[i] = false;
        }


        if (data!=null)
        {
            this.HighScore = data.HighScore;
            this.IsOpenSkin = data.IsOpenSkins;
            this.mony = data.mony;
            this.CaruentSkinNumber = data.CurentSkin;
           
        }

        CuruentSkin = skins[CaruentSkinNumber];
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void KillPlayer()
    {
       
        KillThaPlayer();
        SavingHighScore();
        SaveSystem.SaveData(this);

    }
    /*
    public void ShowDeathPanel()
    {
        if (DeathPanel != null)
            DeathPanel.SetActive(true);
        else
            print("deathpanel is null");
       
       

    }
    */

    public void SavingHighScore()

    {
        Player = GameObject.FindGameObjectWithTag("Player");
        int Score = Player.GetComponent<MovingScript>().Score;

        if (Player != null)
        {
           

            if (Score> HighScore)
            {

                HighScore = Score;

            }


        }

        int ernedMony = (int)(Score * 0.25);
        mony += ernedMony;
        UIManager = GameObject.FindWithTag("UIManager");

        UIManager.GetComponent<UIManager>().ShowErnedMony(ernedMony);
        SaveSystem.SaveData(this);
      
    }
    


   







    //setters and Getters
     
   public int GetHighScore()
    {
        return HighScore;
    }
    
}
