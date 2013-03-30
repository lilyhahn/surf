using UnityEngine;
using System.Collections;

public class PositionChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject fps = GameObject.Find("First Person Controller");
		float tempPos = Terrain.activeTerrain.SampleHeight(fps.transform.position);
		tempPos += 5; //a sloppy fix, it seems to be placing the controller inside the terrain most of the time
		fps.transform.position = new Vector3(fps.transform.position.x, tempPos, fps.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("First Person Controller").transform.position.y < 0){
			Application.LoadLevel("main");
		}
	}
}
