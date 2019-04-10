using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int count = 1;
    float startingPoint;
    // SphereCollider myCollider;

    bool shouldPrintOver20 = true;
    bool shouldPrintOver30 = true;
    // Start is called before the first frame update
    void Start()
    {
        // myCollider = GetComponent<SphereCollider>();
        // Rigidbody myRigidbody = GetComponent<Rigidbody>();
        // Debug.Log("Use Gravity" + myRigidbody.useGravity);
        // Debug.Log("Start");
        // 볼의 처음 시작 위치
        startingPoint = transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        // myCollider.radius = myCollider.radius + 0.01f;
        float distance;
        distance = transform.position.z - startingPoint;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
            // Debug.Log("Space를 눌렀습니다.");

        }
        // 볼의 위치 받아오기
        // Debug.Log("이동거리는 = " + distance);

        if(distance > 30)
        {
            //Debug.Log("Over 30:" + distance);
            if(shouldPrintOver30)
            {
                Debug.Log("Over 30:" + distance);
                shouldPrintOver30 = false;

            }
        }
        else if(distance >20)
        {
            if(shouldPrintOver20)
            {
                //Debug.Log("Over 20:" + distance);
                shouldPrintOver20 = false;

            }
            
        }
        else
        {
           // Debug.Log("Less than 20:" + distance);
        }
        
 
        
    }
}
