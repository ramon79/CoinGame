using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider col)
    {

        // 공이 코인과 닿으면 코인 제거

        if(col.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("RedCoinStart");
            Destroy(gameObject);
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
