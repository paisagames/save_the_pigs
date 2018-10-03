using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour {
	string video;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("video")){
			video=PlayerPrefs.GetString("video");
		}else{
			video="true";
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void playmetod(){
		if(video=="true"){
			SceneManager.LoadScene("introduccion");
		}else{
			SceneManager.LoadScene("escena1");
		}

	}
}
