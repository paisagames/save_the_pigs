using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour {
	public Transform objeto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		transform.LookAt(objeto);
		}
	}
}
