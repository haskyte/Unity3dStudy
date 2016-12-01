using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
//	static float speed = 1;
	// Update is called once per frame
	void Update () {
//		在当前这一帧中，如果用户按了W 就会返回true 否则返回false
	
		if (Input.GetKeyDown (KeyCode.W)) {
			print ("往前走");
		}

		if (Input.GetKeyDown(KeyCode.S)){
			print ("往后退"); 
		}

		if (Input.GetKeyUp (KeyCode.Alpha1)){
			print ("松开了1键");
		}

		//持续按压
		if (Input.GetKey (KeyCode.F)){
			print ("按下了F键");
		}
//		0 鼠标左键 1 鼠标右键 2 鼠标中间滚轮
		if (Input.GetMouseButtonDown(0)){
			print ("按下了鼠标左键");
		}
		if (Input.GetMouseButtonUp(0)){
			print ("松开鼠标左键");
		}
		if (Input.GetMouseButton(0)){
			print ("一直在按鼠标左键");
		}

	}
}
