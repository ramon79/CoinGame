using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update" + count);
        count++;
        
    }
}
