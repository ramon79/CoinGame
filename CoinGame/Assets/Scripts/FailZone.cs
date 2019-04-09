using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collider)
    {
        // Debug.Log(collider.gameObject.name);

        if(collider.gameObject.name == "Ball")
        {
            // 게임 다시 시작
            
            // GameObject.Find("GameManager").SendMessage("RestartGame");
            // GameObject gm = GameObject.Find("GameManager");
            // GameManager gmComponent = gm.GetComponent<GameManager>();
            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
        // Debug.Log(gmComponent.coinCount);

        
    }
}
