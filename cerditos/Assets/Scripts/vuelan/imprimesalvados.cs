using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class imprimesalvados : MonoBehaviour {
	public Text textsalvados;
	public Text textmuertos;

	// Use this for initialization
	void Start () {
		salvadosono.salvados=0;
		salvadosono.muertos=0;
		textmuertos.text=""+0;
		textsalvados.text=""+0;


		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		textmuertos.text=""+salvadosono.muertos;
		textsalvados.text=""+salvadosono.salvados;
		
	}
	}
}
