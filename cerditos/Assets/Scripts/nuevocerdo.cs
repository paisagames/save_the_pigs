using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuevocerdo : MonoBehaviour {
	double tiempo;
	public Transform puntodepartida;
	double x;
	public GameObject cerdito1kg;
	public GameObject cerdito2kg;
	public GameObject cerdito5kg;
	public GameObject cerdito10kg;
	// Use this for initialization
	int randomio;
	void Start () {
		tiempo=11;
		x=12;
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>x){
			randomio=Random.Range(1,5);
			switch(randomio){
				case 1:GameObject nuevocerdox=Instantiate(cerdito1kg,puntodepartida.transform.position,cerdito1kg.transform.rotation);break;
				case 2:GameObject nuevocerdox2=Instantiate(cerdito2kg,puntodepartida.transform.position,cerdito2kg.transform.rotation);break;
				case 3:GameObject nuevocerdox3=Instantiate(cerdito5kg,puntodepartida.transform.position,cerdito5kg.transform.rotation);break;
				case 4:GameObject nuevocerdox4=Instantiate(cerdito10kg,puntodepartida.transform.position,cerdito10kg.transform.rotation);break;
				default:GameObject nuevocerdox5=Instantiate(cerdito1kg,puntodepartida.transform.position,cerdito1kg.transform.rotation);break;
				
			
			}
			if(x>1.05){
			//x-=0.01;
			}
			tiempo=Random.Range(5,10);
		}
	}
}
