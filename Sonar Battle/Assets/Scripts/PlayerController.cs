using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

<<<<<<< HEAD
	public float moveSpeed = 0.5f;

=======
	public float moveSpeed;
    public float multiplySpeed;
>>>>>>> 155e3e0652102e110ffd019d861fbf420cd0fff7
	private Vector3 mousePos;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate()
	{
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePos.z = 0;
		transform.position = Vector3.MoveTowards (transform.position, mousePos, moveSpeed);
		transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);
	}

	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.name == "DefaultWall.prefab")
        {
            Destroy(col.gameObject);
        }
	}
=======
        if (Input.GetKeyDown (KeyCode.Space))
        {
            moveSpeed *= multiplySpeed;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveSpeed /= multiplySpeed;
        }

    }

	/*void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.name == "DefaultWall(Clone)")
        {
            Destroy(col.gameObject);
        }
	}*/
>>>>>>> 155e3e0652102e110ffd019d861fbf420cd0fff7
}
