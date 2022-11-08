using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float deadZone = 1.5f;
    public Transform posPl;
    public float speed = 1f;
    public int behave = 1;
    // Start is called before the first frame update
    void Start()
    {
     posPl = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        switch (behave)
        {
            case 1:
                LookAtPl();
                FollowP1();
                checkDist();
                break;
            case 2:
                LookAtPl();
                break;
            default:
                break;
        }
    }
    void LookAtPl()
    {
        Quaternion lookOnLook = Quaternion.LookRotation(posPl.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }

    void FollowP1()
    {
         transform.position = Vector3.MoveTowards(transform.position, posPl.position, speed);
        // transform.position = Vector3.MoveTowards(transform.position , posPl.position, Time.deltaTime);
    }

    void checkDist()
    {
        float dist = Vector3.Distance(posPl.position, transform.position);

        if (dist < deadZone)
        {
            speed = 0;
            Destroy(this.gameObject);
        }
        else
        {
            speed = 1f;
        }

    }
}
