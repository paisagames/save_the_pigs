using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movepigsito : MonoBehaviour {
	public Rigidbody rigidbody;
	public GameObject alax;
	public int alas;
	bool negativo;
	public Transform posicionala;
	public int kgs;
	Vector3 nuevaposicionala;
	// Use this for initialization
	void Start () {
		
		alas=0;
		negativo=true;
		 nuevaposicionala=new Vector3(posicionala.transform.position.x,posicionala.transform.position.y,posicionala.transform.position.z-1f);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0.018f,0,0);
		nuevaposicionala=new Vector3(posicionala.transform.position.x,posicionala.transform.position.y,posicionala.transform.position.z-0.1f);
		
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
			Destroy(transform.gameObject);
			globalvariables.velocidadbotones+=0.05f;
			salvadosono.muertos++;
		
		}
		if(other.tag=="safe"){
			Destroy(transform.gameObject);
			globalvariables.velocidadbotones+=0.05f;
			salvadosono.salvados++;

		}
	}
	void llevalo(){
		GameObject ala= Instantiate(alax,nuevaposicionala,transform.rotation);
			ala.transform.SetParent(transform);
			ala.transform.localScale=new Vector3(1f,1f,1f);
			
			transform.eulerAngles=new Vector3(0,0,14f);
			rigidbody.useGravity=false;
	}
	
}
