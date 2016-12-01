using UnityEngine;
using System.Collections;

public class turnCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		print (Input.inputString);
//		switch(Input.inputString)
//		{
//		case "a" :
//			GetComponent<Camera>().transform.Rotate(0, 1, 0);
//			break;
//		case "d" :
//			GetComponent<Camera>().transform.Rotate(0, -1, 0);
//			break;
//		case "w" :
//			GetComponent<Camera>().transform.Rotate(1,0,0);
//			break;
//		case "s" :
//			GetComponent<Camera>().transform.Rotate(-1,0, 0);
//			break;
//		}

		if (Input.anyKey) {
			if (Input.GetKey (KeyCode.A)) {
				GetComponent<Camera>().transform.Rotate (0, -1, 0);
			} else if (Input.GetKey (KeyCode.D)) {
				GetComponent<Camera>().transform.Rotate (0, 1, 0);
			} else if (Input.GetKey (KeyCode.W)) {
				GetComponent<Camera>().transform.Translate (0, 0, 1*Time.deltaTime);
			} else if (Input.GetKey (KeyCode.S)) {
				GetComponent<Camera>().transform.Translate (0, 0, -1*Time.deltaTime);
			}
		}

	}
}
