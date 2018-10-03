using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveminiplatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x<5.6f){
		transform.Translate(0.04f,0,0);}
		else{
			transform.position=new Vector3(-5.8f,-7.68f,-0.24f);
		}
	}
}
