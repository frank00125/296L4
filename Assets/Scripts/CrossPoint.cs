using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossPoint : MonoBehaviour {

	public Texture CrossPointTex = null;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnGUI(){
		if(CrossPointTex != null){
			GUI.color = new Color(1,1,1,0.8f);
			Rect drawrect = new Rect((Screen.width * 0.5f) -(CrossPointTex.width * 0.5f),
									(Screen.height * 0.5f) -(CrossPointTex.height * 0.5f),
									CrossPointTex.width, CrossPointTex.height);
			GUI.DrawTexture(drawrect, CrossPointTex);
			
		}
	}
}
