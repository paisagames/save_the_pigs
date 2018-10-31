using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale_pigs : MonoBehaviour {

	Vector3 scale_pigsc;
	// Use this for initialization
	public void Start () {
		scale_pigsc=transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		transform.localScale=scale_pigsc;
	}
	}
}
