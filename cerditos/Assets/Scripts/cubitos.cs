using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubitos : MonoBehaviour {
	public bool activado;
	Vector3 posicioninicial;
	// Use this for initialization
	 void Start () {
		posicioninicial=transform.position;
		activado=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(activado==true){
		//	transform.Translate(0,0.2f,0);
		}
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="dedo"){
			activado=true;
		}
		if(other.tag=="techo"){
			activado=false;
			transform.position=posicioninicial;
		}
	}
}
