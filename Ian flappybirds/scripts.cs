using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obscacle : MonoBehaviour {


    public float Speed = 0;
    public float timebetweenreverse = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * Speed;

        //switch every few seconds
        InvokeRepeating("Reverse", 0, timebetweenreverse);
	}


    void Reverse() {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }

}