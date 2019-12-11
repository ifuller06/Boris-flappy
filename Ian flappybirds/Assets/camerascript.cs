using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {

    public Transform target;

    private void LateUpdate()  {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
