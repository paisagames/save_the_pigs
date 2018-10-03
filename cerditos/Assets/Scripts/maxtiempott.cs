using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxtiempott : MonoBehaviour {
	public double maxtiempototal;
	public static double maxtotal;
	public static double tiempott;

	// Use this for initialization
	 void Start () {
		maxtotal=maxtiempototal;
		tiempott=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(tiempott<maxtotal){
		tiempott=tiempott+Time.deltaTime;}
	}
}
