using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int HighScore;
    public bool [] IsOpenSkins;
    public int mony;
    public int CurentSkin;

    public  PlayerData(GameManager GameManager)
    {
        this.HighScore = GameManager.GetHighScore();
        this.IsOpenSkins = GameManager.IsOpenSkin;
        this.mony = GameManager.mony;
        this.CurentSkin = GameManager.CaruentSkinNumber;
    }
}
