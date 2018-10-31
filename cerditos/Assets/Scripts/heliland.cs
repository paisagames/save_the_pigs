using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliland : MonoBehaviour {
	public Transform inicio;
	public Transform fin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		transform.Translate(0.02f,0,0);
		if(transform.position.x>fin.position.x){
			transform.position=inicio.position;
		}
		}

		
	}
}
