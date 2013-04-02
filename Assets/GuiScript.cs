using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {
	public Texture2D icon;
	public Texture2D button;
	public Texture2D helpicon;
	float iconres;
	float buttonres;
	float helpWidth, helpHeight;
	
	void Start(){
		if(Screen.height >= 768){
			iconres = 256;
			buttonres = 256;
			helpWidth = 512;
			helpHeight = 128;
		}
		else if(Screen.height >= 480){
			iconres = 128;
			buttonres = 128;
			helpWidth = 256;
			helpHeight = 64;
		}
		else{
			iconres = 64;
			buttonres = 64;
			helpWidth = 128;
			helpHeight = 32;
		}
	}
	void OnGUI(){
		GUI.DrawTexture(new Rect((Screen.width/2 - (iconres / 2)), 0, iconres, iconres), icon, ScaleMode.ScaleAndCrop, false, 0);
		if(GUI.Button(new Rect((Screen.width/2 - (buttonres / 2)), (Screen.height/2 -( buttonres /2)), buttonres, buttonres), button)){
			Application.LoadLevel("main");
		}
		if(GUI.Button(new Rect((Screen.width/2 - (helpWidth / 2)), (Screen.height - helpHeight), helpWidth, helpHeight), helpicon)){
			//todo
		}
	}
}
