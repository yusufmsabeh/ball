using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advancedSkinPrice : MonoBehaviour
{

    int advancedskinprice;
    // Start is called before the first frame update
    void Start()
    {

        ButtonsManager buttonsManager = new ButtonsManager();
        advancedskinprice = buttonsManager.AdvancedSkinPrice;
        gameObject.GetComponent<UnityEngine.UI.Text>().text = advancedskinprice.ToString() + "$";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
