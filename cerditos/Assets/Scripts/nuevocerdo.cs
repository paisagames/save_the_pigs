using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nuevocerdo : MonoBehaviour {
	bool gano;
	public Button failb;
	public Image failim;
	public Button restartb;
	public Image restarim;
	public Button menub;
	public Image menui;
	double tiempo;
	public Transform puntodepartida;
	double x;
	public GameObject cerdito1kg;
	public GameObject cerdito2kg;
	public GameObject cerdito5kg;
	public GameObject cerdito10kg;
	int level;
	// Use this for initialization
	int randomio;
	public static int totaldecerdos;
	public static int cerdosquehansalido;
	public Text totalcerdos;

	public Image nextleveli;
	public Button nextlevelb;
	
	void Start () {
		gano=false;

		cerdosquehansalido=0;
		switch(level){
			case 3:totaldecerdos=10;break;
			case 6:totaldecerdos=20;break;
			case 9:totaldecerdos=40;break;
			case 12:totaldecerdos=70;break;
			default:totaldecerdos=10;break;
		}
		tiempo=11;
		x=12;
		totalcerdos.text=""+totaldecerdos;
	}
	
	// Update is called once per frame
	void Update () {
		
		int cerdossalidoslistos=salvadosono.salvados+salvadosono.muertos;
		if(cerdossalidoslistos==totaldecerdos){
			double setentaporciento=totaldecerdos*0.69;
			if(salvadosono.salvados>setentaporciento){
				if(gano==false){

				int levelactual=PlayerPrefs.GetInt("levelactualb");
				levelactual++;
				PlayerPrefs.SetInt("levelactualb",levelactual);
				gano=true;
				}
				menub.enabled=true;
				menui.enabled=true;
				restarim.enabled=true;
				restartb.enabled=true;
				nextlevelb.enabled=true;
				nextleveli.enabled=true;
				
				


			}else{
				failb.enabled=true;
				failim.enabled=true;
				menub.enabled=true;
				menui.enabled=true;
				restarim.enabled=true;
				restartb.enabled=true;

			}
		}




		if(globalvariables.pausado==false){
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>x){
			if(cerdosquehansalido<7){
			randomio=Random.Range(1,5);
			switch(randomio){
				case 1:GameObject nuevocerdox=Instantiate(cerdito1kg,puntodepartida.transform.position,cerdito1kg.transform.rotation);break;
				case 2:GameObject nuevocerdox2=Instantiate(cerdito2kg,puntodepartida.transform.position,cerdito2kg.transform.rotation);break;
				case 3:GameObject nuevocerdox3=Instantiate(cerdito5kg,puntodepartida.transform.position,cerdito5kg.transform.rotation);break;
				case 4:GameObject nuevocerdox4=Instantiate(cerdito10kg,puntodepartida.transform.position,cerdito10kg.transform.rotation);break;
				default:GameObject nuevocerdox5=Instantiate(cerdito1kg,puntodepartida.transform.position,cerdito1kg.transform.rotation);break;
				
			
			}
			cerdosquehansalido++;
			}
			if(x>1.05){
			//x-=0.01;
			}
			tiempo=Random.Range(5,10);
		}
		}
	}
}
