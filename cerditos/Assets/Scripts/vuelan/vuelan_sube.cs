using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vuelan_sube : MonoBehaviour {
	public Transform arriba;
	public Transform abajo;
	bool arribabool;
	// Use this for initialization
	void Start () {
		arribabool=true;
	}
	
	// Update is called once per frame
	void Update () {
		if(arribabool){
			if(transform.position.y<arriba.position.y){
			transform.Translate(0,0,0.025f);}else{
				arribabool=false;
			}
		}else{
			if(transform.position.y>abajo.position.y){
			transform.Translate(0,0,-0.025f);}else{
				arribabool=true;
			}
		}
	}
}
