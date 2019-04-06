using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerawork : MonoBehaviour
{
    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");

        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        
        
        // int [] numbers = {2,4,6,8};

        for(int i =0; i < coins.Length; i++)
        {
            Debug.Log(coins[i].name);

        }


        // Debug.Log(coins[4].name);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("I am Camera. And ball is at" + ball.transform.position.z);
        transform.position = new Vector3(0, ball.transform.position.y + 12 ,ball.transform.position.z - 30);
    }
}
