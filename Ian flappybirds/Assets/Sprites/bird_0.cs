using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_0 : MonoBehaviour {
    // Movement Speed
    public float Speed = 2;

    //Flap force
    public float force = 300;

    public bird_0(float speed, float force)
    {
        Speed = speed;
        this.force = force;
    }

    // Use this for initialization
    void Start () {
            //Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) 
        {
            //Flap
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*force);
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //restart
        Application.LoadLevel(Application.loadedLevel);
    }
}
