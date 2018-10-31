using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menupauseplay : MonoBehaviour {
	public Image pausaimage;
	public Button pausabuton;
	public Image playimage;
	public Button playbutton;
	public Image menuimage;
	public Button menubuton;


	// Use this for initialization
	void Start () {
		globalvariables.pausado=false;
		pausabuton.enabled=true;
		pausaimage.enabled=true;
		playbutton.enabled=false;
		playimage.enabled=false;
		menuimage.enabled=false;
		menubuton.enabled=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pausa(){
		globalvariables.pausado=true;
		pausabuton.enabled=false;
		pausaimage.enabled=false;
		playbutton.enabled=true;
		playimage.enabled=true;
		menuimage.enabled=true;
		menubuton.enabled=true;
		
	}
	public void continuee(){
		globalvariables.pausado=false;
		pausabuton.enabled=true;
		pausaimage.enabled=true;
		playbutton.enabled=false;
		playimage.enabled=false;
		menuimage.enabled=false;
		menubuton.enabled=false;
	}

	public void menuback(){
		globalvariables.pausado=false;
		SceneManager.LoadScene("menu");
		
	}
}
