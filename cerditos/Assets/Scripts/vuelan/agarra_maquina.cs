using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class agarra_maquina : MonoBehaviour {
	public Transform flechita;
	public Image btn1;
	public Image btn2;
	public Image btn5;
	public Image btn10;
	
//	public Text texto;
	public Transform maquinabase;
	public GameObject bolita;
	public SpriteRenderer maquina;
	public SpriteRenderer sr1kg;
	public SpriteRenderer sr2kg;
	public SpriteRenderer sr5kg;
	public SpriteRenderer sr10kg;
	bool bajamaquinabool;
	public Transform grisabajo;
	public Transform grisarriba;
	double tiempo;
	// Use this for initialization
	void Start () {
		tiempo=0;
		bajamaquinabool=false;
		globalvariables.garra=1;
	}
	
	// Update is called once per frame
	void Update () {
		if((globalvariables.velocidadbotones*-15f)>-180f)
		{flechita.transform.localEulerAngles=new Vector3(0,0,globalvariables.velocidadbotones*-15f);
	//	texto.text="maq:"+globalvariables.garra;
		}

		if(bajamaquinabool==true){
			if(transform.position.y>grisabajo.position.y){
				tiempo=tiempo+Time.deltaTime;
				if(tiempo>0.4){
				Vector3 vec=new Vector3(transform.position.x,transform.position.y+0.21f,transform.position.z);
				tiempo=0;
				
				GameObject bolitaobj=Instantiate(bolita,vec,transform.rotation);
				bolitaobj.transform.SetParent(maquinabase);
				}
				transform.Translate(0,-0.01f,0);
			}else{bajamaquinabool=false;}
			
		}else{
			if(transform.position.y<grisarriba.position.y){
				transform.Translate(0,0.01f,0);
			}


		}
		
		
	}
	public void bajamaquina1(){
		btn1.color=Color.green;
		btn2.color=Color.white;
		btn5.color=Color.white;
		btn10.color=Color.white;
		bajamaquinabool=false;
		globalvariables.garra=1;
		changeimage();
		bajamaquinabool=true;
	}
	public void bajamaquina2(){
		btn2.color=Color.green;
		btn1.color=Color.white;
		btn5.color=Color.white;
		btn10.color=Color.white;
		bajamaquinabool=false;
		globalvariables.garra=2;
		changeimage();
		bajamaquinabool=true;
	}
	public void bajamaquina5(){
		btn5.color=Color.green;
		btn2.color=Color.white;
		btn1.color=Color.white;
		btn10.color=Color.white;
		bajamaquinabool=false;
		globalvariables.garra=5;
		changeimage();
		bajamaquinabool=true;
	}
	public void bajamaquina10(){
		btn10.color=Color.green;
		btn2.color=Color.white;
		btn5.color=Color.white;
		btn1.color=Color.white;
		bajamaquinabool=false;
		globalvariables.garra=10;
		changeimage();
		bajamaquinabool=true;
	}
	public void changeimage(){
		switch(globalvariables.garra){
			case 1:maquina.sprite=sr1kg.sprite;break;
			case 2:maquina.sprite=sr2kg.sprite;break;
			case 5:maquina.sprite=sr5kg.sprite;break;
			case 10:maquina.sprite=sr10kg.sprite;break;
		}
	}
}
