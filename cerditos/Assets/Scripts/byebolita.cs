using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byebolita : MonoBehaviour {
	public Transform posicioninicial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="garra"){
			transform.position=posicioninicial.position;
		}
	}
}
