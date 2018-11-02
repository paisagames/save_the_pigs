using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class cambia_nivel_principal : MonoBehaviour {
	int levelactual;
	public Image maquinaimage;
	public Button b_maquina;
	public Image succionadoraImaf;
	public Button b_succiona;
	public Image vuelanimage;
	public Button b_vuelan;

	public GameObject dificultad;
	string eleccion;



	// Use this for initialization
	void Start () {
		eleccion="";
	if(PlayerPrefs.HasKey("levelactualb")){
			levelactual=PlayerPrefs.GetInt("levelactualb");
			
		}else{
			PlayerPrefs.SetInt("levelactualb",1);
			levelactual=1;
			
		}


		if(levelactual>1){
			maquinaimage.enabled=true;
			b_maquina.enabled=true;
		}
		if(levelactual>2){
			succionadoraImaf.enabled=true;
			b_succiona.enabled=true;

		}	
		if(levelactual>3){
			vuelanimage.enabled=true;
			b_vuelan.enabled=true;
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void aplasta(){
		eleccion="aplasta";
		dificultad.SetActive(true);
		//SceneManager.LoadScene("escena1");
	}
	public void maquina(){
		eleccion="maquina";
		dificultad.SetActive(true);
		//SceneManager.LoadScene("succionadora");
	}
	public void vuelan(){
		eleccion="vuelan";
		dificultad.SetActive(true);
		//SceneManager.LoadScene("cerdosvuelan");
	}

	public void easy(){
		switch(eleccion){
			case "aplasta":PlayerPrefs.SetInt("levelactualb",1);
			SceneManager.LoadScene("escena1");break;
			case "maquina":PlayerPrefs.SetInt("levelactualb",2);
			SceneManager.LoadScene("succionadora");break;
			case "vuelan":PlayerPrefs.SetInt("levelactualb",3);
			SceneManager.LoadScene("cerdosvuelan");break;
			
		}
	}
	public void medium(){
		switch(eleccion){
			case "aplasta":PlayerPrefs.SetInt("levelactualb",4);
			SceneManager.LoadScene("escena1");break;
			case "maquina":PlayerPrefs.SetInt("levelactualb",5);
			SceneManager.LoadScene("succionadora");break;
			case "vuelan":PlayerPrefs.SetInt("levelactualb",6);
			SceneManager.LoadScene("cerdosvuelan");break;
			
		}
	}
	public void difucult(){
		switch(eleccion){
			case "aplasta":PlayerPrefs.SetInt("levelactualb",7);
			SceneManager.LoadScene("escena1");break;
			case "maquina":PlayerPrefs.SetInt("levelactualb",8);
			SceneManager.LoadScene("succionadora");break;
			case "vuelan":PlayerPrefs.SetInt("levelactualb",9);
			SceneManager.LoadScene("cerdosvuelan");break;
			
		}
	}
	public void experto(){
		switch(eleccion){
			case "aplasta":PlayerPrefs.SetInt("levelactualb",10);
			SceneManager.LoadScene("escena1");break;
			case "maquina":PlayerPrefs.SetInt("levelactualb",11);
			SceneManager.LoadScene("succionadora");break;
			case "vuelan":PlayerPrefs.SetInt("levelactualb",12);
			SceneManager.LoadScene("cerdosvuelan");break;
			
		}
	}
	public void back(){
		dificultad.SetActive(false);
	}
}
