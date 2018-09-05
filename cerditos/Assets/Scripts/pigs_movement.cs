using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pigs_movement : MonoBehaviour {

	public Transform posicion1;
	public Transform posicion2;
	public Transform posicion3;
	public Transform posicion4;
	public Text texto;

	public double tiempo;

	int posicionactual;
	// Use this for initialization
	void Start () {
		
		posicionactual=Random.Range(1,4);
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.deltaTime;
		texto.text=""+tiempo;


		if(tiempo>3){
			newrandom();
			tiempo=0;
		}

		switch(posicionactual){
			case 1: transform.LookAt(posicion1);break;
			case 2:transform.LookAt(posicion2);break;
			case 3:transform.LookAt(posicion3);break;
			case 4:transform.LookAt(posicion4);break;

		}
		transform.Translate(0,0,0.003f);



		
	}
	
	void newrandom(){
		double postemp=posicionactual;
		posicionactual=Random.Range(1,4);
		if(posicionactual==postemp){newrandom();}
	}
}
