using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerate : MonoBehaviour
{
    [SerializeField]
     GameObject EnemyPrefab;
    [SerializeField]
    GameObject Player;

    Transform PlayerTransform;


    float lastObjectPosition;
    float NextPlayerPosition;
    float SpaceBetweenEnemys;
    // Start is called before the first frame update
    void Start()
    {
        lastObjectPosition = 5;
        NextPlayerPosition = 1;
        SpaceBetweenEnemys =5;

        PlayerTransform = Player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            if ((PlayerTransform.position.y >= NextPlayerPosition))
            {

                for (int i = 0; i < 5; i++)
                {
                    float RandomNumberForXAxis = UnityEngine.Random.Range(3.5f, 7.63f);
                    lastObjectPosition += SpaceBetweenEnemys;
                    Instantiate(EnemyPrefab, new Vector2(RandomNumberForXAxis, lastObjectPosition), Quaternion.identity);
                }
                NextPlayerPosition = lastObjectPosition - 10;
            }
          
        }
        
    }

    // increasing the space between obstacles

    void increaseSpace()
    {
        SpaceBetweenEnemys += 0.001f;
        SpaceBetweenEnemys =Mathf.Clamp(SpaceBetweenEnemys, 5, 8);
    }
}
