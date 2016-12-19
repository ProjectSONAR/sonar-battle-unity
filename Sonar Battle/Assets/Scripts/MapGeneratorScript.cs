using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneratorScript : MonoBehaviour {

	public int Seed = 12345;

	public float Filledness = 20;

	public int MapSizeX = 75;
	public int MapSizeY = 75;

	public List<GameObject> wallObjectsList;

	private List<List<GameObject>> map;

	// Use this for initialization
	void Start () {

		Random.InitState(Seed);

		for (int cntx = -MapSizeX; cntx < MapSizeX; cntx++) {
			for (int cnty = -MapSizeY; cnty < MapSizeY; cnty++) {
				if (Random.Range (0, 100) < Filledness || cntx == -MapSizeX || cntx == MapSizeX-1 || cnty == -MapSizeY || cnty == MapSizeY-1) {
					Instantiate (wallObjectsList [0], new Vector3 (cntx, cnty, 0), Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
