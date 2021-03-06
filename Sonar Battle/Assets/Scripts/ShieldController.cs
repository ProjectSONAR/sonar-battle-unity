﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour {

	public GameObject playerSprite;

	public GameObject shield;
	public GameObject noiseLevel;

	public bool IsShieldActive = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		shield.transform.position = playerSprite.transform.position;
		shield.transform.rotation = playerSprite.transform.rotation;

		noiseLevel.transform.position = playerSprite.transform.position;
		noiseLevel.transform.rotation = playerSprite.transform.rotation;



		if (Input.GetKeyDown (KeyCode.Q)) {
			IsShieldActive = !IsShieldActive;

			if (IsShieldActive) {
				shield.SetActive (true);
				noiseLevel.transform.localScale = new Vector3(7,7,1);
			} else {
				shield.SetActive (false);
				noiseLevel.transform.localScale = new Vector3(4,4,1);
			}
		}
	}
}
