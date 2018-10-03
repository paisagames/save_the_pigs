using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("levelactualb")){
			nivelactual.levelactual=PlayerPrefs.GetInt("levelactualb");
			
		}else{
			PlayerPrefs.SetInt("levelactualb",1);
			nivelactual.levelactual=1;
		
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void restartM(){
		
		SceneManager.LoadScene("escena1");
	}
	public void nextlevel(){
		nivelactual.levelactual++;
		SceneManager.LoadScene("levelsmenu");
	}
}
