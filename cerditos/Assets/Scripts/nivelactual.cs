using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivelactual : MonoBehaviour {
	public static int levelactual;
	public Animator animacion;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("levelactualb")){
			levelactual=PlayerPrefs.GetInt("levelactualb");
			animacion.SetInteger("nivel",levelactual);
		}else{
			PlayerPrefs.SetInt("levelactualb",1);
			levelactual=1;
			animacion.SetInteger("nivel",1);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void iralnivel(){
		switch(levelactual){
			case 1:SceneManager.LoadScene("escena1");break;
			case 4:SceneManager.LoadScene("escena1");break;
			case 7:SceneManager.LoadScene("escena1");break;

			case 2:SceneManager.LoadScene("maquinita");break;
			case 5:SceneManager.LoadScene("maquinita");break;
			case 8:SceneManager.LoadScene("maquinita");break;


			case 3:SceneManager.LoadScene("camionsito");break;
			case 6:SceneManager.LoadScene("camionsito");break;
			case 9:SceneManager.LoadScene("camionsito");break;
		}
	}
}
