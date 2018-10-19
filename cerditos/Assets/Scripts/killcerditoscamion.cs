using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killcerditoscamion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="destroy"){
			Destroy(transform.gameObject);
			globalvariables.totalcerdos--;
		}
	}
}
