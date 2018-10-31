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



	// Use this for initialization
	void Start () {
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
		SceneManager.LoadScene("escena1");
	}
	public void maquina(){
		SceneManager.LoadScene("succionadora");
	}
	public void vuelan(){
		SceneManager.LoadScene("cerdosvuelan");
	}
}
