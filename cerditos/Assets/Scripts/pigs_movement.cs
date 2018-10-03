using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pigs_movement : MonoBehaviour {
	public Material azul;
	public Material pink;
	bool agarradobool;
	bool timeoff;
	Vector3 scale_pigsc;
	bool boolcentro;
	bool movementbool;
	public Transform centerposicion;
	public Transform posicion1;
	public Transform posicion2;
	public Transform posicion3;
	public Transform posicion4;
	public Transform posicion5;
	public Transform posicion6;
	public Transform posicion7;
	public Transform posicion8;
	public Transform posicion9;
	public Transform posicion10;
	public Transform posicion11;
	public Transform posicion12;
	public Transform posicion13;
	public Transform posicion14;
	public Transform posicion15;
	public Transform posicion16;
	public Transform centerofcenter;
	public Text texto;
	public Text textosalvados;

	public double tiempo;

	int posicionactual;
	public MeshRenderer mr;
	// Use this for initialization
	 void Start () {
		 
	
		scale_pigsc=transform.localScale;
		suma_pesos.cerdos_salvados=0;
		movementbool=true;
		timeoff=false;
		Random.Range(1,16);
		suma_pesos.objetos_agarrados=0;
		boolcentro=false;
		agarradobool=false;
	}
	
	// Update is called once per frame
	void Update () {
		int tiempoquehapasado=(int)maxtiempott.tiempott;
		int limite=(int)maxtiempott.maxtotal;
		textosalvados.text="Saved Pigs:"+suma_pesos.cerdos_salvados+"  -------"+(limite-tiempoquehapasado)+"seg";
				
		tiempo=tiempo+Time.deltaTime;
		texto.text=""+tiempo;

	
		if(tiempo>5){//&&posicion!=5
			newrandom();
			tiempo=0;
		}
		if(timeoff==false){
		switch(posicionactual){
			case 1: transform.LookAt(posicion1);break;
			case 2:transform.LookAt(posicion2);break;
			case 3:transform.LookAt(posicion3);break;
			case 4:transform.LookAt(posicion4);break;
			case 5:transform.LookAt(posicion5);break;
			case 6:transform.LookAt(posicion6);break;
			case 7:transform.LookAt(posicion7);break;
			case 8:transform.LookAt(posicion8);break;
			case 9:transform.LookAt(posicion9);break;
			case 10:transform.LookAt(posicion10);break;
			case 11:transform.LookAt(posicion11);break;
			case 12:transform.LookAt(posicion12);break;
			case 13:transform.LookAt(posicion13);break;
			case 14:transform.LookAt(posicion14);break;
			case 15:transform.LookAt(posicion15);break;
			case 16:transform.LookAt(posicion16);break;
			case 17:transform.LookAt(centerofcenter);break;
			case 18:movementbool=false;break;

		}
		}
		if(posicionactual!=17&&posicionactual!=18){
			mr.material=pink;
			movementbool=true;
		}else{movementbool=false;}

		
		if(maxtiempott.tiempott>=maxtiempott.maxtotal-3){
			timeoff=true;
			
		}
	if(timeoff==true){
		transform.LookAt(centerofcenter);
		posicionactual=17;
	}
	if(movementbool==true){
		transform.Translate(0,0,0.0102f);// 0.0202f
	}
	
	//if(agarradobool==false){
		scale_pigsc=transform.localScale;
	//}


	}
	
	void newrandom(){
		double postemp=posicionactual;
		posicionactual=Random.Range(1,16);
		if(posicionactual==postemp){newrandom();}
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="cubo"){//este no es el error
			if(timeoff==true){
				movementbool=false;
			}
		}
		if(other.tag=="safe"){
			Destroy(transform.gameObject);
			suma_pesos.cerdos_salvados++;
			textosalvados.text="Saved Pigs:"+suma_pesos.cerdos_salvados+",time:"+(maxtiempott.maxtotal-maxtiempott.tiempott)+"seg";
		}


		///////////////////////////////
		if(other.tag=="dedo"){
			
			posicionactual=18;
			tiempo=-5;
			
			
			mr.material=azul;
			
			textosalvados.text="Saved Pigs:"+suma_pesos.cerdos_salvados+",time:"+(maxtiempott.maxtotal-maxtiempott.tiempott)+"seg";
			
		}else{
			agarradobool=false;
			}
		////////////////////////////
		
		
		
		if(other.tag=="center3"){
			//if(posicionactual==17){
			//posicionactual=18;
			//tiempo=-5;}
			
			
				textosalvados.text="Saved Pigs:"+suma_pesos.cerdos_salvados+",time:"+(maxtiempott.maxtotal-maxtiempott.tiempott)+"seg";
				
				
					
			boolcentro=true;
			
	}
 
	}

	void OnTriggerExit(Collider other){
		
		if(other.tag=="center"){
			boolcentro=false;
		}
	}
}
