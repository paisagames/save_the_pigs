﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotax : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		transform.Rotate(0,0.2f,0);
	}}
}
