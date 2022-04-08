using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
     GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        gameObject.GetComponent<UnityEngine.UI.Text>().text = GameManager.GetComponent<GameManager>().GetHighScore().ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
