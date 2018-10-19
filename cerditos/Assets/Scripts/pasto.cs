using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasto : MonoBehaviour {
	public Transform inicio;
	public Transform fin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,-1f);
		if(transform.position.z<=fin.position.z){
			transform.position=inicio.position;

	}
	}
}
