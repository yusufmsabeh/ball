using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = Player.GetComponent<MovingScript>().Score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
