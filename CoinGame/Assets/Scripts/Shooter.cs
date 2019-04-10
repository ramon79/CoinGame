using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject stone;

    //두 물체간에 충돌이 발생한 경우
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);

        // 내 위치에서 공의 위치를 빼면 방향이 나옴
        Vector3 direction = transform.position - collision.gameObject.transform.position;

        //아래는 힘

        direction = direction.normalized * 1000;

        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
   
    }
    /* void TestMethod(string name, int a)
    {
        
        float distance = Vector3.Distance(GameObject.Find(name).transform.position, transform.position);
        Debug.Log(name + "까지 거리" + distance);


    }
    */

    // obstacle 움직임 값
    float delta = -0.1f;
    // Start is called before the first frame update
    void Start()
    {
        // TestMethod("Ball");
    }

    // Update is called once per frame

    float timeCount = 0;
    void Update()
    {

        // TestMethod("Ball", 0);

        timeCount +=Time.deltaTime;
        if(timeCount > 3)
        {
            // Debug.Log("볼을 던져라");

            Instantiate(stone, transform.position, Quaternion.identity);
            timeCount = 0;
        }

        float newXPosition = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newXPosition, transform.localPosition.y, transform.localPosition.z);
        if(transform.localPosition.x < -3.5)
        {
            delta = 0.1f;
        }
        else if(transform.localPosition.x > 3.5)
        {
            delta = -0.1f;
        }
        
    }
}
