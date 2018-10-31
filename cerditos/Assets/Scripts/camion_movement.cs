using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camion_movement : MonoBehaviour {
	public Transform camara;
	bool movement;
	bool down_derecha;
	bool down_izquierda;

	// Use this for initialization
	void Start () {
		down_derecha=false;
		movement=true;
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		//si el cubo esta triggereado no afecta
		if(movement){
			//camara.transform.Translate(0,0.1f,0);
		}
		if(down_derecha){
			if(transform.position.x<84f){
			transform.Translate(0.05f,0,0);}
			}//antes transform.Rotate(0,0,-1.0f);}
		if(down_izquierda){
			if(transform.position.x>72f){
			transform.Translate(-0.05f,0,0);}
			}//antes transform.Rotate(0,0,1.0f);}
		}
	}
	public void derecha_down(){
		down_derecha=true;
	}
	public void derecha_up(){
		down_derecha=false;
	}
	public void izquierda_down(){
		down_izquierda=true;
	}
	public void izquierda_up(){
		down_izquierda=false;
	}
}
