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
		int sp=(int)suma_pesos.pesototal;
		texto.text=""+sp+"kg";
		
	}
}
