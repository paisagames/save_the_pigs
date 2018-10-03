using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pesomaximoaguantado : MonoBehaviour {
	public float pesomaximoaguante;
	public Text textodepesomaximo;
	// Use this for initialization
	 void Start () {
		suma_pesos.pesomaximoaguantado=pesomaximoaguante;
		textodepesomaximo.text="Max "+suma_pesos.pesomaximoaguantado+"kg";
	}
	
	// Update is called once per frame
	void Update () {
		textodepesomaximo.text="Max "+suma_pesos.pesomaximoaguantado+"kg";
	}
}
