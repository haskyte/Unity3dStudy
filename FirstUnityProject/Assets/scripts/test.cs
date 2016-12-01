using UnityEngine;
using System.Collections;

// 如果脚本要挂载到游戏对象身上就必须要继承于MonoBehaviour
public class test : MonoBehaviour {
	public  int age;
	public  string newname;

	public void log(){
		Debug.Log ("++++++" + newname + age);
	}
	// Use this for initialization
	void Start () {
//		gameObject表示当前脚本组件所挂载的游戏对象

		Debug.Log ("test 脚本挂载到了 " + gameObject.name + "的身上");
		print ("组件名字 " + this.name);
//		每个游戏对象都至少有一个组件 Transfrom
//		transform 表示当前游戏对象身上的 Transfrom 组件

		print (transform.position.x);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
