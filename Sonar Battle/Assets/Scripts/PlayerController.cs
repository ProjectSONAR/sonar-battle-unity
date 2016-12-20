using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
    public float multiplySpeed;
	private Vector3 mousePos;
    public List<GameObject> Lasers;
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate()
	{
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePos.z = 0;
		transform.position = Vector3.MoveTowards (transform.position, mousePos, moveSpeed);
		transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(Lasers[0], new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        }
    }

	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.Space))
=======

        if (Input.GetKeyDown (KeyCode.Space))
>>>>>>> d15ff490b744295655c0cdaf4a5bb30b568ff201
        {
            moveSpeed *= multiplySpeed;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveSpeed /= multiplySpeed;
        }
    }
}
