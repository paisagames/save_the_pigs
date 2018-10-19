using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sameposition : MonoBehaviour {
	public Transform posicionbase;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=posicionbase.position;
		
	}
}
