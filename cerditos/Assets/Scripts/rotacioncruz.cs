using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacioncruz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x>0.15f){
			transform.Rotate(0,2f,0);
		}else{
		if(transform.position.x<-0.15f){
			transform.Rotate(0,-2f,0);
		}else{transform.Rotate(0,0,0);}}
		
	}
}
