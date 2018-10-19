using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changefollow : MonoBehaviour {
public Transform pos1;
public Transform pos2;
public Transform pos3;
public Transform pos4;
public Transform pos5;
public Transform pos6;
public Transform pos7;
public Transform pos8;
public Transform pos9;
public Transform pos10;
int i=1;
public double tiempo;
	// Use this for initialization
	void Start () {
		tiempo=0;
		transform.position=pos1.position;
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>5){
			i=Random.Range(1,10);
			tiempo=0;
			
		}
		switch(i){
			case 1:transform.position=pos1.position;break;
			case 2:transform.position=pos2.position;break;
			case 3:transform.position=pos3.position;break;
			case 4:transform.position=pos4.position;break;
			case 5:transform.position=pos5.position;break;
			case 6:transform.position=pos5.position;break;
			case 7:transform.position=pos5.position;break;
			case 8:transform.position=pos5.position;break;
			case 9:transform.position=pos5.position;break;
			case 10:transform.position=pos5.position;break;
		}


	}
}
