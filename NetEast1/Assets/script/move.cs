using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	// 浮点数变量自定义
	public float speed;	// Use this for initialization
	void Start () {
		// 获取摄像机 . 获取摄像机脚本组件 . 让player 赋值为自身
//		GameObject.Find("Main Camera"). GetComponent<SceneCamera> (). player = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		WalkForward ();
	}

	void WalkForward(){
		transform.position = transform.position + transform.forward * speed * Time.fixedDeltaTime;

	}
}
