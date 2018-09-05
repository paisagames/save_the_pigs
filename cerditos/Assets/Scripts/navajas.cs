using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navajas : MonoBehaviour {



public double maxtiempo;
string move;bool move2;
double tiempo;
	// Use this for initialization
	void Start () {
	move="inicio";
	
		tiempo=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(move=="inicio"){
		tiempo=tiempo+Time.deltaTime;
		}

		if(tiempo>=maxtiempo){
			move="machuca";
			tiempo=0;
			
		}

		if(move=="machuca"){
		transform.Translate(-0.02f,0,0);
			
		}

		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="maquina"){
	
			move="para";
			tiempo=0;
		}
	}
}
