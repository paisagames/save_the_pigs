using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxtiempott : MonoBehaviour {
	 double maxtiempototal;
	public static double maxtotal;
	public static double tiempott;
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
			case 1:maxtiempototal=180f;break;
			case 4:maxtiempototal=150f;break;
			case 7:maxtiempototal=120f;break;
			case 10:maxtiempototal=100f;break;
			case 13:maxtiempototal=80f;break;
			case 16:maxtiempototal=70f;break;
			default:maxtiempototal=70f;break;
		}
		maxtotal=maxtiempototal;
		tiempott=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(tiempott<maxtotal){
		tiempott=tiempott+Time.deltaTime;}
	}
}
