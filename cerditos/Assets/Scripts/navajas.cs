using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class navajas : MonoBehaviour {
public Button Rstarbtn;
public Image Rstarimage;
public Button Nextlvlbtn;
public Image Nextlvlimage;
public Rigidbody sangre;

public double maxtiempo;
public static double maxtiempo2;
string move;bool move2;
public static double tiempo;
	// Use this for initialization
	void Start () {
	move="inicio";
		
	
		maxtiempo2=maxtiempott.maxtotal;
	}
	
	// Update is called once per frame
	void Update () {
		if(Setentaporciento.porcentajedecerdossalvados>=100){
			PlayerPrefs.SetInt("levelactualb",2);
				Nextlvlbtn.enabled=true;
				Nextlvlimage.enabled=true;
				Rstarbtn.enabled=true;
			Rstarimage.enabled=true;
			
			}

		if(move=="inicio"){
		tiempo=tiempo+Time.deltaTime;
		}

		if(move!="para"){
		if(maxtiempott.tiempott>=maxtiempott.maxtotal){
			move="machuca";
			tiempo=0;
		}
		}

		if(move=="machuca"){
		transform.Translate(-0.02f,0,0);
			
		}
		if(move=="para"){
			transform.localPosition=new Vector3(0f,-5.33f,-0.05f);
		}

		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="cubo"){
			Rstarbtn.enabled=true;
			Rstarimage.enabled=true;
			
			
			move="para";
			tiempo=0;


			///level pass??
			if(Setentaporciento.porcentajedecerdossalvados>70){
				Nextlvlbtn.enabled=true;
				Nextlvlimage.enabled=true;
			}
		}
		if(other.tag=="pig"){
			if(move!="inicio"){
			
			Rigidbody instantiatedProjectile = Instantiate (sangre, other.transform.position, sangre.rotation) as Rigidbody;
			Destroy(other.gameObject);
			}
		
		}
	}
}
