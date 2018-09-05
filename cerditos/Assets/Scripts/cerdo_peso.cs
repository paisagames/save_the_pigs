using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerdo_peso : MonoBehaviour {
	public float peso;
	// Use this for initialization
	void Start () {
		suma_pesos.pesototal=0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="center"){
			suma_pesos.pesototal+=peso;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag=="center"){
		suma_pesos.pesototal-=peso;
		}
	}
}
