using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour {

public GameObject RedCube;
public GameObject BlueCube;
public Material MRed;
public Material MRedDark;
public Material MBlue;
public Material MBlueDark;

private int changeCount = 0;

	void Start () {
		RedCube.GetComponent<Renderer>().material = MRed;
		BlueCube.GetComponent<Renderer>().material = MBlue;
		//3秒たったあと5秒間隔で呼ぶ
		InvokeRepeating("ChangeSignal", 3f, 5f);
	}

	void ChangeSignal () {
		changeCount++;
		if(changeCount%2==0){
			RedCube.GetComponent<Renderer>().material = MRedDark;
			BlueCube.GetComponent<Renderer>().material = MBlue;
		} else {
			RedCube.GetComponent<Renderer>().material = MRed;
			BlueCube.GetComponent<Renderer>().material = MBlueDark;
		}
	}
}
