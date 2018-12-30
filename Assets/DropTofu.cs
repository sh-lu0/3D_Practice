using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTofu : MonoBehaviour {

public GameObject MyTofu;
private int TofuCount = 0;

	void Start () {
		InvokeRepeating("DropOne", 2f,1f);
	}
	void DropOne() {
		TofuCount++;
		Instantiate(MyTofu, new Vector3(0,5,0), Quaternion.identity);
		if(TofuCount==100){
			CancelInvoke();
		}
	}
}
