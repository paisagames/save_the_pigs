using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cerdosamaquina : MonoBehaviour {
	public Rigidbody cerdo;
	public Text texto;
	public Transform puntodelanzamiento;
	// Use this for initialization
	double tiempo;
	void Start () {
		tiempo=0;
		globalvariables.cerdossalvados=0;
		globalvariables.bajas=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>4){
			ponuncerdo();
			tiempo=0;
		}
	texto.text="tiempo:"+tiempo+",dt:"+Time.deltaTime;	
	}
	void ponuncerdo(){
		Rigidbody instantiatedProjectile = Instantiate (cerdo, puntodelanzamiento.position, transform.rotation) as Rigidbody;

	}
}
