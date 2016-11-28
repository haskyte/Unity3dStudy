using UnityEngine;
using System.Collections;

public class roteBox : MonoBehaviour {

	//定义一个变量
//	float rotSpeed = 120.0f;
	bool rotEnabled = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(rotEnabled){
			
			transform.Rotate (0,Bridge.speed*Time.deltaTime,0);		

		}
	}

	void OnMouseDown(){
		rotEnabled = !rotEnabled;
	}

}
