using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonyScript : MonoBehaviour
{

     GameObject GameManager;

        
    // Start is called before the first frame update
    void Start()
    {

        GameManager = GameObject.FindWithTag("GameManager");
        GetMony();
        ButtonsManager.ChangeMoney += ChangeMony;
  
    }
  

    void OnDisable()
    {
        ButtonsManager.ChangeMoney -= ChangeMony;
    }
  

    // Update is called once per frame
   

    void ChangeMony()
    {
      
        GetMony();

    }

    void GetMony()
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = GameManager.GetComponent<GameManager>().mony.ToString() + "$";

    }
}
