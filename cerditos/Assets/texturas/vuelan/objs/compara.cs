using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compara : MonoBehaviour {
	public Text texto;
	// Use this for initialization
	void Start () {
		texto.text=""+globalvariables.garra;
		
	}
	
	// Update is called once per frame
	void Update () {
			texto.text=""+globalvariables.garra;
	}
}
