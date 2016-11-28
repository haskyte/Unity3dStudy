using UnityEngine;
using System.Collections;

public class ChangeSpeed : MonoBehaviour {

	public float change = 30.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Bridge.speed += change;
	}
}
