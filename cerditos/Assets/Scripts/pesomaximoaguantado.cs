using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pesomaximoaguantado : MonoBehaviour {
	 float pesomaximoaguante;
	public Text textodepesomaximo;
	int nivelactual;
	// Use this for initialization
	 void Start () {


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
			case 1:pesomaximoaguante=25f;break;
			case 4:pesomaximoaguante=45f;break;
			case 7:pesomaximoaguante=70f;break;
			case 10:pesomaximoaguante=85f;break;
			case 13:pesomaximoaguante=100f;break;
			case 16:pesomaximoaguante=140f;break;
			default:pesomaximoaguante=180f;break;
		}
		suma_pesos.pesomaximoaguantado=pesomaximoaguante;
		textodepesomaximo.text="Max "+suma_pesos.pesomaximoaguantado+"kg";
	}
	
	// Update is called once per frame
	void Update () {
		textodepesomaximo.text="Max "+suma_pesos.pesomaximoaguantado+"kg";
	}
}
