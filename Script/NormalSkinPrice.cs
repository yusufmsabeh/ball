using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSkinPrice : MonoBehaviour
{
    // Start is called before the first frame update
    int normalskinprice;
    
    void Start()
    {
        ButtonsManager buttonsManager = new ButtonsManager();
        normalskinprice =buttonsManager.NormalSkinPrice;
        gameObject.GetComponent<UnityEngine.UI.Text>().text = normalskinprice.ToString()+"$";
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
