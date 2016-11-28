using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {

	static float speed = 5.0f;
	static Transform newobject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (x, 0, z);
		if(Input.GetButtonDown("Fire1"))
		{
			GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			objCube.AddComponent<Rigidbody>();
			objCube.name = "Sphere";
			objCube.GetComponent<Renderer>().material.color = Color.blue;
			objCube.transform.position = transform.position;

			objCube.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 8000);
		}

	}
}

//#pragma strict
//
//function Start () {
//
//}
//var speed : int = 5;
//var newobject: Transform;
//
//function Update () {
//	var x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
//	var z = Input.GetAxis("Vertical")*Time.deltaTime*speed;
//	transform.Translate(x,0,z);
//
//	if (Input.GetButtonDown("Fire1")) {
//		// statement
//		var bullet:Transform = Instantiate(newobject,transform.position,transform.rotation);
//		var fwd:Vector3 = transform.TransformDirection(Vector3.forward);
//		bullet.GetComponent<Rigidbody>().AddForce(fwd*28000);
//	}
//
//}
