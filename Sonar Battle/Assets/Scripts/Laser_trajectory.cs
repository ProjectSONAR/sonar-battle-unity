using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Laser_trajectory : MonoBehaviour {


    public float movespeed;
	public GameObject root;

	// Use this for initialization
	void Start () {
		//Debug.Log (transform.rotation.ToString());
		root.transform.position = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		//transform.Translate((transform.right + transform.up) * movespeed);
		//Debug.DrawLine(root.transform.position, (root.transform.position + root.transform.up));
		root.transform.position += root.transform.up * movespeed;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
		//Triggers when it is shot as well, it hits the player
		//Debug.Log ("Hit!");
        if (col.gameObject.name == "DefaultWall(Clone)")
        {
			//Obviously triggers when it hits a wall
			//Debug.Log ("Hit wall!");

			//Destroy the wall
			Destroy(col.gameObject);

			//Destroy the bullet
			Destroy(gameObject);
        }
    }
}
=======

>>>>>>> 37272a69921e4fbb01468cead4ea90ca7627dde8
