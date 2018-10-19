using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class movebotones : MonoBehaviour {
	public Text vel;
	Vector3 posinicial;
	public Transform limite;
	public Transform inicial;
	int levelactual;
	// Use this for initialization
	void Start () {
		posinicial=transform.position;

	/*	if(PlayerPrefs.HasKey("levelactualb")){
			levelactual=PlayerPrefs.GetInt("levelactualb");
			
		}else{
			PlayerPrefs.SetInt("levelactualb",3);
			levelactual=3;
			
		}*/
		levelactual=3;
		switch(levelactual){
			case 3:globalvariables.velocidadbotones=0.52f;break;
			case 6:globalvariables.velocidadbotones=2f;break;//cerdo num 15 del case 3
			case 9:globalvariables.velocidadbotones=5f;break;//cerdo num 23 del case 3
			case 12:globalvariables.velocidadbotones=10f;break;//cerdo num 30 del case 3
			case 15:globalvariables.velocidadbotones=15f;break;//cerdo num 34 del case 3
			case 18:globalvariables.velocidadbotones=20f;break;//cerdo num 34 del case 3
		}
		
		
		
	}
	
	// Update is called once per frame
	void levelactuals(){
		switch(levelactual){
			case 3:globalvariables.velocidadbotones=0.52f;break;
			case 6:globalvariables.velocidadbotones=2f;break;//cerdo num 15 del case 3
			case 9:globalvariables.velocidadbotones=5f;break;//cerdo num 23 del case 3
			case 12:globalvariables.velocidadbotones=10f;break;//cerdo num 30 del case 3
			case 15:globalvariables.velocidadbotones=15f;break;//cerdo num 34 del case 3
			case 18:globalvariables.velocidadbotones=20f;break;//cerdo num 34 del case 3
		}
	}
	void Update () {
		vel.text="vel;"+globalvariables.velocidadbotones;
		if(Input.GetKeyDown(KeyCode.E)){
			levelactual+=3;
			levelactuals();
		}
		transform.Translate(globalvariables.velocidadbotones,0,0);
		if(transform.position.x>limite.position.x){
			transform.position=inicial.position;
		}
	}
}
