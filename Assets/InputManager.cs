using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Screen.showCursor = true;
		}
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel("main");
		}
			
	}
}
