using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obscacles : MonoBehaviour
{

    public float Speed=0;
    public float timeBetweenReverse=0;

    // Use this for initialization
    void Start()  {

        GetComponent<Rigidbody2D>().velocity = Vector2.up * Speed;

        //switch every few seconds
        InvokeRepeating("Reverse", 0, timeBetweenReverse);
    }

    // Update is called once per frame
    void Update()   {
    }


    void Reverse()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }

}