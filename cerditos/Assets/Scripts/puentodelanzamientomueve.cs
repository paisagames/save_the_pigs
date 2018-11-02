using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puentodelanzamientomueve : MonoBehaviour {
	bool direccion;
	double tiempo;
	// Use this for initialization
	void Start () {
		direccion=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>4){
			if(direccion){direccion=false;}else{direccion=true;}
			tiempo=0;
		}
		if(direccion){
			transform.Translate(0.02f,0,0);
		}else{
			transform.Translate(-0.02f,0,0);
		}
		
	}
}
