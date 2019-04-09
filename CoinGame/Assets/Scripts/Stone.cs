﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    Vector3 Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("Ball").transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, 0.1f);
        transform.Rotate(new Vector3(0,0,5));
        
    }

    void OnTriggerEnter(Collider collider)
    {
        

        if(collider.gameObject.name == "Ball")
        {

            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();

        }
    }
}
