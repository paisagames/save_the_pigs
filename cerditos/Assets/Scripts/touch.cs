using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touch : MonoBehaviour {
	public Image touchhelper;
	public Transform spherhelper;
	//public RectTransform canvass;
	float canvas_X;
	float canvas_Y;
	float mitadx;
	float mitady;
	/*public Transform limXp;
	public Transform limXn;
	public Transform limYp;
	public Transform limYn;

	float limxp;
	float limxn;
	float limyp;
	float limyn;*/
	// Use this for initialization
	public void Start () {
		//canvas_X = canvass.sizeDelta.x;
		//canvas_Y = canvass.sizeDelta.y;
		mitadx=canvas_X/2f;
		mitady=canvas_Y/2f;

	/*	limxp=limXp.transform.position.x;
		limxn=limXn.transform.position.x;
		limyp=limYp.transform.position.y;
		limyn=limYn.transform.position.y;*/
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		/*mitadx=canvas_X/2f;
		mitady=canvas_Y/2f;*/
		 if (Input.touchCount > 0) {// && Input.GetTouch(0).phase == TouchPhase.Moved)
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
            Vector2 touch2 = Input.GetTouch (0).position;
			touchhelper.transform.position=touch2;
			spherhelper.transform.localPosition=new Vector3((touchhelper.transform.localPosition.x/10f)-5f,spherhelper.transform.localPosition.y,(touchhelper.transform.localPosition.y/10f)-5f);
		}
	}
	}
}
