using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cambiasprite : MonoBehaviour {
public Text textocerdo;
public Text textobajas;
bool touchmachin;
public Animator animacion;



	// Use this for initialization
	void Start () {
		
		touchmachin=false;
	}
	
	// Update is called once per frame
	void Update () {
		textocerdo.text=""+globalvariables.cerdossalvados;
		textobajas.text=""+globalvariables.bajas;
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="maquina"){
			
				
		animacion.SetBool("tocino",true);
		if(touchmachin==false){
		globalvariables.bajas++;
		touchmachin=true;}


		}
		if(other.tag=="safe"){
			Destroy(this.gameObject);
			globalvariables.cerdossalvados++;	

		}
		if(other.tag=="destroy"){
			Destroy(this.gameObject);
		}
	}
}
