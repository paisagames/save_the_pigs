using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setentaporciento : MonoBehaviour {
	//public Text fff; ACTIVARLO PARA SABER QUE OBJETO TIENE EL CODIGO
	public Transform punto_delanzamiento1;
	public Transform punto_delanzamiento2;
	public Transform punto_delanzamiento3;
	public Transform punto_delanzamiento4;
	GameObject cerdito;
	public GameObject cerdito1;
	public GameObject cerdito2;
	public GameObject cerdito3;
	public GameObject cerdito4;
	Transform puntodelanzamiento;
	public static int cerdosenescena;
	public Text porcentajetext;
	 public static double porcentajedecerdossalvados;
	 int nivelactual;
	// Use this for initialization
	void Start () {
		
		//fff.text="Fff";
		if(PlayerPrefs.HasKey("levelactualb")){
			nivelactual=PlayerPrefs.GetInt("levelactualb");
			if(nivelactual!=1&&nivelactual!=4&&nivelactual!=7&&nivelactual!=10&&nivelactual!=13&&nivelactual!=16){
				nivelactual=1;
			}
		}else{
			PlayerPrefs.SetInt("levelactualb",1);
			nivelactual=1;
		}

		switch(nivelactual){
			case 1:cerdosenescena=8;break;
			case 4:cerdosenescena=12;break;
			case 7:cerdosenescena=16;break;
			case 10:cerdosenescena=20;break;
			case 13:cerdosenescena=24;break;
			case 16:cerdosenescena=30;break;
			default:cerdosenescena=8;break;
		}
		int randomio;
		for(int i=4;i<=cerdosenescena-1;i++){
			randomio=Random.Range(1,5);
			switch(randomio){
				case 1:puntodelanzamiento=punto_delanzamiento1;cerdito=cerdito1;break;
				case 2:puntodelanzamiento=punto_delanzamiento2;cerdito=cerdito2;break;
				case 3:puntodelanzamiento=punto_delanzamiento3;cerdito=cerdito3;break;
				case 4:puntodelanzamiento=punto_delanzamiento4;cerdito=cerdito4;break;
				case 5:puntodelanzamiento=punto_delanzamiento3;cerdito=cerdito3;break;
				

			}

			GameObject instantiatedProjectile = Instantiate (cerdito, puntodelanzamiento.position, transform.rotation) as GameObject;

		}
		
		if(suma_pesos.cerdos_salvados>0){
	 porcentajedecerdossalvados=(suma_pesos.cerdos_salvados*100)/cerdosenescena;
				}else{
					porcentajedecerdossalvados=0;
				}
	}
	
	// Update is called once per frame
	void Update () {
		if(suma_pesos.cerdos_salvados>0){
		 porcentajedecerdossalvados=(suma_pesos.cerdos_salvados*100)/cerdosenescena;
		 }else{porcentajedecerdossalvados=0;}
		 porcentajetext.text=porcentajedecerdossalvados+"%";
	
	}
}
