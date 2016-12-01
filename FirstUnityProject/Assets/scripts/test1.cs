using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		test t = GetComponent<test>();
		t.age = 10;
		t.newname = "heheda";

		t.log ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
