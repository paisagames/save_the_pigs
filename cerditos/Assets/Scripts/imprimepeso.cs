using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imprimepeso : MonoBehaviour {

	public Text texto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		texto.text=""+suma_pesos.pesototal;
		
	}
}
