using UnityEngine;
using System.Collections;

public class PositionChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("First Person Controller").transform.position.y < 0){
			Application.LoadLevel("main");
		}
	}
}
