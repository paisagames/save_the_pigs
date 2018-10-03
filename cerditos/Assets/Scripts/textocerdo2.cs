using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textocerdo2 : MonoBehaviour {
	int d;
	public Text texto;
	// Use this for initialization
	void Start () {
		d=1;
		changedialogo();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changedialogo(){
		switch(d){
			case 1:d=2;texto.text="Juan the farmer send my friends a place similar to this one";break;
			case 2:d=3;texto.text="I´m pretty sure that terrible things happen there";break;
			case 3:d=4;texto.text="What you have to do is enter there.";break;
			case 4:d=5;texto.text="Once you are inside you will see a circle that says 'press me' or something like that";break;
			case 5:d=6;texto.text="that circle is the mechanism I made to save my fellows";break;
			case 6:d=7;texto.text="Everytime you press that circle, a platform inside will go up";break;
			case 7:d=8;texto.text="You need to find a way to push my fellows to that cirlce and then press it to make the platform going up an save them";break;
			case 8:d=9;texto.text="For doing that I´ll give you an Ice cube that you can move around the place";break;
			case 9:d=10;texto.text="If you touch each fellow with that Ice cube, they will be frezed for a moment.";break;
			case 10:d=11;texto.text="Why do you need to freeze them?? Because they are moving all the time!!";break;
			case 11:d=12;texto.text="I know is not the best way to save them but is the only way I have found until now";break;
			case 12:d=13;texto.text="Ok! So, now go there and tell me if you need some help.";break;
			case 13:SceneManager.LoadScene("levelsmenu");break;
			//case 9:d1.sprite=d10.sprite;d=10;break;
			
		}
	}
}
