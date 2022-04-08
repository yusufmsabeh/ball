using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {

        ButtonsManager.ChangeSkin += CheckSkin;
        GameManager = GameObject.FindWithTag("GameManager");
        string name = gameObject.name;
        CheckSkin(int.Parse(name));
       
    }
   

    void OnDisable()
    {
        ButtonsManager.ChangeSkin -= CheckSkin;
      
    }
  
    // Update is called once per frame
    void Update()
    {

    }
        
   

    void CheckSkin(int SkinID)
    {

        BuySkin(SkinID);

        EquipSkin(SkinID);

    }

    void BuySkin(int SkinID)
    {
        GameManager = GameObject.FindWithTag("GameManager");
       
        SkinID = int.Parse(this.gameObject.name);
        if (GameManager.GetComponent<GameManager>().IsOpenSkin[SkinID])
        {
            gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = "Equip";
        }


    }
    void EquipSkin(int SkinID)
    {
        Image image = gameObject.GetComponent<Image>();
        Color oldColor = image.color;

        if (GameManager.GetComponent<GameManager>().CaruentSkinNumber.ToString() == gameObject.name)
        {

            Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 0.5f);

            gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = "Equipped";
            image.color = newColor;

        }
        else if (GameManager.GetComponent<GameManager>().CaruentSkinNumber.ToString() != gameObject.name)
        {
            Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 1);
           // gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = "Equip";
            image.color = newColor;
        }
    }
}
