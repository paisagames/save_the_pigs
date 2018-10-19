using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveleftright : MonoBehaviour {
	public Transform maquina;
	Vector2 newPosition;
	bool moveleft;
	bool moveright;
	public Image centerimage;
	float x;
	float newx;
	Vector2 nuevotoque;
	// Use this for initialization
	void Start () {
		moveleft=false;
		moveright=false;
		newPosition=centerimage.rectTransform.position;
		x=0;
		newx=newPosition.x;
		nuevotoque=newPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(moveleft){
			maquina.transform.Translate(-0.02f,0,0);
			x=-2f;
			centerimage.rectTransform.Translate(-07f,0,0);//5bien
			getnewpositionmetod();

		}
		if(moveright){
			maquina.transform.Translate(0.02f,0,0);
			x=2f;
			centerimage.rectTransform.Translate(07f,0,0);
			getnewpositionmetod();
		}
		 if (Input.touchCount > 0) {
			// && Input.GetTouch(0).phase == TouchPhase.Moved)
            // Get movement of the finger since last frame
            Vector2 touch2 = Input.GetTouch (0).position;
			nuevotoque=touch2;
			
			if(centerimage.rectTransform.position.x<(nuevotoque.x-0.5f)){
				moveright=true;
			}else{moveright=false;}
			if(centerimage.rectTransform.position.x>(nuevotoque.x+0.5f)){
				moveleft=true;
			}else{moveleft=false;}
		}else{
			moveright=false;
			moveleft=false;
		}
		
		

	}
	public void getnewpositionmetod(){
		/* if (Input.touchCount > 0) {
			// && Input.GetTouch(0).phase == TouchPhase.Moved)
            // Get movement of the finger since last frame
            Vector2 touch2 = Input.GetTouch (0).position;
			if(moveleft){
				if(touch2.x>centerimage.rectTransform.position.x){
					moveleft=false;
				}
			}
			if(moveright){
				if(touch2.x<centerimage.rectTransform.position.x){
					moveright=false;
				}
			}
			}*/
	}
	public void leftUp(){
		//moveleft=false;
		
	}
	public void leftDown(){
		
		//moveleft=true;
		//getnewpositionmetod();
	}
	public void rightUp(){
		//moveright=false;
		
	}
	public void rightDown(){
		//moveright=true;
		//getnewpositionmetod();
		}
}
