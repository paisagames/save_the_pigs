using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerdo_peso : MonoBehaviour {
	public Material kg1;
	public Material kg2;
	public Material kg5;
	public Material kg10;

	public MeshRenderer plano;
	public float peso;
	bool entro;
	
	// Use this for initialization
	 void Start () {
		suma_pesos.pesototal=0f;
		entro=false;		
		

		
			if(peso==1f){plano.material=kg1;}
			if(peso==2f){plano.material=kg2;}
			if(peso==5f){plano.material=kg5;}
			if(peso==10f){plano.material=kg10;}
				
		
	}
	
	// Update is called once per frame
	void Update () {
		//plano.material=kg2;
		
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="center2"){
			if(entro==false){
			suma_pesos.pesototal+=peso;
			entro=true;
			}
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag=="center2"){
			if(entro==true){
		suma_pesos.pesototal-=peso;
		entro=false;
		}
		
		}
	}
}
