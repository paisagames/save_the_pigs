using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cambiasprite : MonoBehaviour {
public Text textocerdo;
public Text textobajas;

public Animator animacion;
public AudioSource audio1;
public AudioSource audio2;
public AudioSource audio3;
public AudioSource audio4;
public Transform puntodelanzamiento;
int randy;


	// Use this for initialization
	void Start () {
		randy=0;

		
		
	}
	
	// Update is called once per frame
	void Update () {
		textocerdo.text=""+globalvariables.cerdossalvados;
		textobajas.text=""+globalvariables.bajas;
		
	}
	void OnTriggerEnter(Collider other){
		if(globalvariables.pausado==false){
		if(other.tag=="maquina"){
			
				
		animacion.SetBool("tocino",true);
		randy=Random.Range(1,5);
			suena();
		


		}
		if(other.tag=="safe"){
			randy=Random.Range(1,5);
			suena();
			//Destroy(this.gameObject);
			globalvariables.cerdossalvados++;
			transform.position=puntodelanzamiento.position;	
			
			

		}
		if(other.tag=="destroy"){
			animacion.SetBool("tocino",false);
			globalvariables.bajas++;
			transform.position=puntodelanzamiento.position;
			//Destroy(this.gameObject);
			

		}
	}
}
void suena(){
	randy=Random.Range(1,5);
	switch(randy){
		case 1:audio1.playOnAwake=true;audio1.Play();break;
		case 2:audio2.playOnAwake=true;audio2.Play();break;
		case 3:audio3.playOnAwake=true;audio3.Play();break;
		case 4:audio4.playOnAwake=true;audio4.Play();break;
		default:audio1.playOnAwake=true;audio1.Play();break;
	}
}
}
