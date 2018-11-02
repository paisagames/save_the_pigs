using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movepigsito : MonoBehaviour {
	public AudioSource audio1;
public AudioSource audio2;
public AudioSource audio3;
public AudioSource audio4;
int randy;
public Transform puntodelanzamiento;
	public Rigidbody rigidbody;
	
	//public GameObject alax;
	public int alas;
	bool negativo;
	public Transform posicionala;
	public int kgs;
	public GameObject ala;
	Vector3 nuevaposicionala;
	Vector3 EularagunlosIniciales;
	// Use this for initialization
	void Start () {
		EularagunlosIniciales=transform.eulerAngles;
		alas=0;
		negativo=true;
		 nuevaposicionala=new Vector3(posicionala.transform.position.x,posicionala.transform.position.y,posicionala.transform.position.z-1f);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		transform.Translate(0.018f,0,0);
		nuevaposicionala=new Vector3(posicionala.transform.position.x,posicionala.transform.position.y,posicionala.transform.position.z-0.1f);
		
	}
	}
	void OnTriggerEnter(Collider other){
		
		if(other.tag=="garra"){
			
			//if(negativo){
				if(alas<1){
				//	transform.localScale=new Vector3(0.2f,0.2f,0.2f);
					if(kgs==globalvariables.garra){llevalo();
					alas++;
					}
					
					negativo=false;
				
			
				

			}
		}
		if(other.tag=="destroy"){
			
			//Destroy(transform.gameObject);
			ala.transform.SetParent(null);
			globalvariables.velocidadbotones+=0.05f;
			salvadosono.muertos++;
			if(nuevocerdo.cerdosquehansalido<nuevocerdo.totaldecerdos)
			{transform.position=puntodelanzamiento.position;
			nuevocerdo.cerdosquehansalido++;
			}
			
		
		}
		if(other.tag=="safe"){
			//Destroy(transform.gameObject);
			ala.transform.SetParent(null);
			globalvariables.velocidadbotones+=0.05f;
			salvadosono.salvados++;

			if(nuevocerdo.cerdosquehansalido<nuevocerdo.totaldecerdos)
			{
			transform.position=puntodelanzamiento.position;
			nuevocerdo.cerdosquehansalido++;
			}
			resetealo();
		}
	}
	void resetealo(){
		transform.eulerAngles=EularagunlosIniciales;
		rigidbody.useGravity=true;
		ala.transform.position=new Vector3(50f,100f,0);

	}
	void llevalo(){
		//ala= Instantiate(alax,nuevaposicionala,transform.rotation);
		ala.transform.position=nuevaposicionala;
			ala.transform.SetParent(transform);
			ala.transform.localScale=new Vector3(0.5f,0.5f,0.5f);
			
			transform.eulerAngles=new Vector3(0,0,14f);
			rigidbody.useGravity=false;
			suena();
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
