using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cerdosamaquina : MonoBehaviour {
	public Image failwin;
	public Button botonnextlevel;
	public Image fail;
	public Image win;
	int cerdoslanzados;
	public Rigidbody cerdo;
	public Text texto;
	string ganooperdio;
	int maxcerdoslanzados;
	
	public Transform puntodelanzamiento;
	// Use this for initialization
	double tiempo;
	int nivelactual;
	void Start () {
		ganooperdio="perdio";
		cerdoslanzados=0;
		tiempo=0;
		globalvariables.cerdossalvados=0;
		globalvariables.bajas=0;
		if(PlayerPrefs.HasKey("levelactualb")){
			nivelactual=PlayerPrefs.GetInt("levelactualb");
		}else{nivelactual=2;}
		switch(nivelactual){
			case 2:maxcerdoslanzados=100;break;
			case 5:maxcerdoslanzados=200;break;
			case 8:maxcerdoslanzados=300;break;
			case 11:maxcerdoslanzados=500;break;
			case 14:maxcerdoslanzados=750;break;
			case 17:maxcerdoslanzados=1000;break;
			default:maxcerdoslanzados=100;break;
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>4){
			if(cerdoslanzados<maxcerdoslanzados){
			ponuncerdo();}
			else{
				failwin.enabled=true;
				botonnextlevel.enabled=true;
				if(globalvariables.cerdossalvados>maxcerdoslanzados/2){
					ganooperdio="gano";
					failwin.sprite=win.sprite;
				}else{
					failwin.sprite=fail.sprite;
					ganooperdio="perdio";
				}
				botonnextlevel.enabled=true;
				failwin.enabled=true;

			}
			cerdoslanzados++;
			tiempo=0;
			
		}
		
	texto.text="tiempo:"+tiempo+",dt:"+Time.deltaTime;	
		}

	}
	void ponuncerdo(){
		Rigidbody instantiatedProjectile = Instantiate (cerdo, puntodelanzamiento.position, transform.rotation) as Rigidbody;

	}
	public void nextlevel(){
		if(ganooperdio=="gano"){
			SceneManager.LoadScene("levelsmenu");
		}else{
			int nxtlvlscene=3;
			switch(nivelactual){
				case 2:nxtlvlscene=3;break;
				case 5:nxtlvlscene=6;break;
				case 8:nxtlvlscene=9;break;
				case 11:nxtlvlscene=12;break;
				case 14:nxtlvlscene=15;break;
				case 17:nxtlvlscene=18;break;
				default:nxtlvlscene=3;break;
			}
			PlayerPrefs.SetInt("levelactualb",nxtlvlscene);
			SceneManager.LoadScene("succionadora");
		}

	}
}
