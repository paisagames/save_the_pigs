using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gps : MonoBehaviour {

	// Use this for initialization
	public Transform target1;
	public Transform target2;
	public Transform target3;
	public Transform target4;
	public Transform target5;
	public Transform target6;
	public Transform target7;
	public Transform target8;
	public Transform target9;
	public Transform target10;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(globalvariables.target){
			case 1:transform.LookAt(target1);break;
			case 2:transform.LookAt(target2);break;
			case 3:transform.LookAt(target3);break;
			case 4:transform.LookAt(target4);break;
			case 5:transform.LookAt(target5);break;
			case 6:transform.LookAt(target6);break;
			case 7:transform.LookAt(target7);break;
			case 8:transform.LookAt(target8);break;
			case 9:transform.LookAt(target9);break;
			case 10:transform.LookAt(target10);break;
		}
		
	}
}
