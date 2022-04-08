using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    int CameraAHead;
    public GameObject player;
    void Start()
    {
        CameraAHead = 2;
    }

    // Update is called once per frame
    void Update()

    {
        if(player!=null)
            transform.position = new Vector3(transform.position.x, player.GetComponent<Transform>().position.y+CameraAHead,-10 );
    }
}
