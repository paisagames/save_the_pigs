using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchtarget : MonoBehaviour {
	public Text textmetros;
	public Text texttotalcerdos;
	public Transform sphera;
	float velocidadsphera;
	int metros;


	public SpriteRenderer carro3;
public BoxCollider carro3bx;


public SpriteRenderer carro4;
public BoxCollider carro4bx;
public SpriteRenderer carro5;
public BoxCollider carro5bx;
public SpriteRenderer sr1;
public SpriteRenderer sr2;
public SpriteRenderer sr3;
public SpriteRenderer sr4;
	// Use this for initialization
	void Start () {
		globalvariables.totalcerdos=48;
		velocidadsphera=1f;
		metros=0;
		globalvariables.target=1;
		texttotalcerdos.text="pigs:"+globalvariables.totalcerdos;
	}
	
	// Update is called once per frame
	void Update () {
		sphera.Rotate(0,velocidadsphera,0);
		if(metros>300){
			carro3.enabled=true;
			carro3bx.enabled=true;
		}
		if(metros>500){
			carro4.enabled=true;
			carro4bx.enabled=true;
		}

			if(metros>800){
			carro5.enabled=true;
			carro5bx.enabled=true;
		}

		if(metros>=800&&sr1.transform.position.y<-10f){
			sr1.enabled=true;
			sr2.enabled=true;
			sr3.enabled=true;
			sr4.enabled=true;
		}



	texttotalcerdos.text="pigs:"+globalvariables.totalcerdos;	
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="target"){
			Destroy(other.gameObject);
			globalvariables.target++;
		}
		if(other.tag=="metros"){
			metros+=100;
			velocidadsphera+=0.002f;
			textmetros.text=metros+"m"+velocidadsphera;

		}
	}
}
