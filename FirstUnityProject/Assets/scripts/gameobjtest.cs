using UnityEngine;
using System.Collections;

public class gameobjtest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.name = "老王";

		gameObject.tag = "Player";

		//获取游戏对象的激活状态
		print(gameObject.activeSelf);
		//设置游戏对象的激活状态
		gameObject.SetActive (true);

//		Rigidbody r = gameObject.GetComponent<Rigidbody> ();

//		Light l = gameObject.AddComponent<Light> ();

//		GameObject g = GameObject.FindGameObjectWithTag("Player");

//		GameObject gg = GameObject.FindWithTag ("Player");

//		GameObject ggg = GameObject.Find ("Main Camera");
//		ggg.name = "主摄像机";

//		GameObject[] games = GameObject.FindGameObjectsWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S)){
			GameObject.Destroy (gameObject, 2f);
		}

	}
}
