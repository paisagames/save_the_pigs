﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
	public Transform followt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		transform.LookAt(followt);
		transform.Translate(0,0,0.24f);
		}
	}
}
