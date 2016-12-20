using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_trajectory : MonoBehaviour {


    public float movespeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(transform.up * movespeed);
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "DefaultWall(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
