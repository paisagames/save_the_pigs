using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour {
public float x;
public float y;
public float z;
double seconds;

bool direccion;
	// Use this for initialization
	void Start () {
		seconds=0;
		direccion=true;
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		seconds+=Time.deltaTime;
		if (seconds>2){
			seconds=0;
			if(direccion){direccion=false;}else{direccion=true;}
		}

		if(direccion){
		transform.Translate(x,y,z);}
		else{transform.Translate(-x,y,z);}
		
	}
	}
}
