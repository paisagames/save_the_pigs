using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class dialogo : MonoBehaviour {
	int d;
public SpriteRenderer d1;
public SpriteRenderer d2;
public SpriteRenderer d3;
public SpriteRenderer d4;
public SpriteRenderer d5;
public SpriteRenderer d6;
public SpriteRenderer d7;
public SpriteRenderer d8;
public SpriteRenderer d9;
public SpriteRenderer d10;
	// Use this for initialization
	void Start () {
		d=1;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changedialogo(){
		switch(d){
			case 1:d1.sprite=d2.sprite;d=2;break;
			case 2:d1.sprite=d3.sprite;d=3;break;
			case 3:d1.sprite=d4.sprite;d=4;break;
			case 4:d1.sprite=d5.sprite;d=5;break;
			case 5:d1.sprite=d6.sprite;d=6;break;
			case 6:d1.sprite=d7.sprite;d=7;break;
			case 7:d1.sprite=d8.sprite;d=8;break;
			case 8:SceneManager.LoadScene("escena2");break;
			//case 9:d1.sprite=d10.sprite;d=10;break;
			
		}
	}
}
