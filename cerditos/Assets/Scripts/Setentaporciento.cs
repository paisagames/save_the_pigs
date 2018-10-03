using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setentaporciento : MonoBehaviour {
	public static int cerdosenescena;
	public Text porcentajetext;
	 public static double porcentajedecerdossalvados;
	// Use this for initialization
	void Start () {
		cerdosenescena=16;
		if(suma_pesos.cerdos_salvados>0){
	 porcentajedecerdossalvados=(suma_pesos.cerdos_salvados*100)/16;
				}else{
					porcentajedecerdossalvados=0;
				}
	}
	
	// Update is called once per frame
	void Update () {
		if(suma_pesos.cerdos_salvados>0){
		 porcentajedecerdossalvados=(suma_pesos.cerdos_salvados*100)/16;
		 }else{porcentajedecerdossalvados=0;}
		 porcentajetext.text=porcentajedecerdossalvados+"%";
	
	}
}
