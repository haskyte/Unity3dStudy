using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour {
	static public int a = 2;
	// Use this for initialization
	void Start () {
		Debug.Log ("test2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getA()
	{
		return a;
	}

}
