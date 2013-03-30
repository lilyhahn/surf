using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {
	public Texture2D icon;
	public Texture2D button;
	float iconres;
	float buttonres;
	
	void Start(){
		if(Screen.height >= 768){
			iconres = 256;
			buttonres = 256;
		}
		else if(Screen.height >= 480){
			iconres = 128;
			buttonres = 128;
		}
		else{
			iconres = 64;
			buttonres = 128;
		}
	}
	void OnGUI(){
		GUI.DrawTexture(new Rect((Screen.width/2 - (iconres / 2)), 40, iconres, iconres), icon, ScaleMode.ScaleAndCrop, false, 0);
		if(GUI.Button(new Rect((Screen.width/2 - (buttonres / 2)), (Screen.height - buttonres) - 40, buttonres, buttonres), button)){
			Application.LoadLevel("main");
		}
		
	}
}
