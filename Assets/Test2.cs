using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	private Transform myTransform;

	void Start () {
		myTransform = GetComponent<Transform>();
	}

	void Update () {
		myTransform.Rotate(0, Time.deltaTime*360/3, 0);
	}

	void OnMouseDown(){
		Application.LoadLevel("SCENE1");
	}

}
