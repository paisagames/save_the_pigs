using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sube : MonoBehaviour {
	public Color green;
	public Color red;
	public Color blue;
	bool subirbool;
	public Text textomax;
	public Image imagepanel;

	Vector3 posicioninicial;
	// Use this for initialization
	public void Start () {
		subirbool=false;
		posicioninicial=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		if(subirbool==true){
			transform.Translate(0,0.02f,0);
			
			imagepanel.color=green;
		}
		if(suma_pesos.pesototal>suma_pesos.pesomaximoaguantado){
			textomax.text="TOO MUCH WEIGHT!!";
			if(subirbool==false){
			imagepanel.color=red;}
		}else{
			if(subirbool==false){
			imagepanel.color=blue;
			
		}
		}
		}
	}
	public void subir(){
		//si el peso es menor al peso que resiste o el tiempo no ha llegado al limite
		if(suma_pesos.pesototal<=suma_pesos.pesomaximoaguantado&&maxtiempott.tiempott<maxtiempott.maxtotal-5){
		subirbool=true;}else{
			textomax.text="TOO MUCH WEIGHT!!";
		}
	}
	void OnTriggerEnter(Collider other)
	{if(other.tag=="safe")
		{	subirbool=false;
			transform.position=posicioninicial;}
		
	}
}
