using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class nivelactual : MonoBehaviour {
	public static bool muuvfondo;
	public Image fondo1;
	public Image fondo2;
	public static int levelactual;
	public Animator animacion;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("levelactualb")){
			levelactual=PlayerPrefs.GetInt("levelactualb");
			animacion.SetInteger("nivel",levelactual);// animacion.SetInteger("nivel",levelactual);
		}else{
			PlayerPrefs.SetInt("levelactualb",1);
			levelactual=1;
			animacion.SetInteger("nivel",1);
		}
		//levelactual=7;
		//animacion.SetInteger("nivel",7);
		muuvfondo=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		if(muuvfondo){
			fondo2.transform.position=fondo1.transform.position;
			
			//fondo1.transform.localScale=new Vector3(0,0,0);

		}
		}
	}
	public void iralnivel(){
		switch(levelactual){
			case 1:SceneManager.LoadScene("escena1");break;
			case 4:SceneManager.LoadScene("escena1");break;
			case 7:SceneManager.LoadScene("escena1");break;

			case 2:SceneManager.LoadScene("historia_2");break;
			case 5:SceneManager.LoadScene("maquinita");break;
			case 8:SceneManager.LoadScene("maquinita");break;


			case 3:SceneManager.LoadScene("camionsito");break;
			case 6:SceneManager.LoadScene("camionsito");break;
			case 9:SceneManager.LoadScene("camionsito");break;
		}
	}
}
