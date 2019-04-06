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
            
            Application.LoadLevel("Game");

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
