using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinCount = 0;
    public Text coinText;

    void GetCoin()
    {
        coinCount++;
        //Debug.Log("동전: " + coinCount);
        coinText.text = coinCount + "개";

    }

    public void RestartGame()
    {
        Application.LoadLevel("Game");
    }

    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        for(int i = 0; i<obstacles.Length; i++)
        {
            Destroy(obstacles[i]);

        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
