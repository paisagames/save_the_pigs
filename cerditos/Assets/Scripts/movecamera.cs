using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movecamera : MonoBehaviour {
	public Image imagemove;
	public Image borderarroba;
	public Image borderabajo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(imagemove.transform.position.y>borderarroba.transform.position.y){
			if(transform.position.y<29.0f){
			transform.Translate(0,0.07f,0);
			}
		}
		if(imagemove.transform.position.y<borderabajo.transform.position.y){
			if(transform.position.y>-2.7f){
			transform.Translate(0,-0.07f,0);}
		}
		
	}
}
