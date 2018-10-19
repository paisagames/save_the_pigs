using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchbottons : MonoBehaviour {
	public GameObject boton1;
	public GameObject boton2;
	public GameObject boton5;
	public GameObject boton10;
	public GameObject posicionzero;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void switchear(){
		int s=Random.Range(0,5);
		Vector3 posicionhelp=new Vector3(0,0,0);
		switch(s){
			case 0:
			posicionhelp=posicionzero.transform.position;
		posicionzero.transform.position=boton2.transform.position;
		boton2.transform.position=posicionhelp;
		break;
			case 1:posicionhelp=boton1.transform.position;
		boton1.transform.position=boton2.transform.position;
		boton2.transform.position=posicionhelp;
		break;

		case 2: posicionhelp=boton2.transform.position;
		boton2.transform.position=boton5.transform.position;
		boton5.transform.position=posicionhelp;
		break;
		case 3:posicionhelp=boton5.transform.position;
		boton5.transform.position=boton10.transform.position;
		boton10.transform.position=posicionhelp;
		break;
		case 4: posicionhelp=boton10.transform.position;
		boton10.transform.position=boton1.transform.position;
		boton1.transform.position=posicionhelp;
		break;
		case 5:posicionhelp=posicionzero.transform.position;
		posicionzero.transform.position=boton5.transform.position;
		boton5.transform.position=posicionhelp;
		break;

		}

		
	}
	public void switchear_2(){
	

	}
	public void switchear_5(){
		

	}
	public void switchear_10(){
		

	}
}
