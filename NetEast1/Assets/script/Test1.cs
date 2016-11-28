using UnityEngine;
using System.Collections;

public class Test1 : MonoBehaviour {
	public int b;
	// Use this for initialization
	void Start () {
		Debug.Log ("test1");
		b = GameObject.Find("Sphere").GetComponent<Test2>().getA();


		Debug.Log (b);
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody>().AddForce(Vector3.forward*1000);

	}
}
