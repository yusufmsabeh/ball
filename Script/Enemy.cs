using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Camera MainCam;
    bool IsPassed = false;

     GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
        Player = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= (MainCam.transform.position.y - 6))
        {
            Destroy(this.gameObject);
        }
        collecteScore();
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }

    private void collecteScore()
    {
        if (Player != null)
        {
            if (Player.transform.position.y > transform.position.y && !IsPassed)
            {
                Player.GetComponent<MovingScript>().UpdateScore();
                IsPassed = true;
            }
        }
        
        
    }
}
