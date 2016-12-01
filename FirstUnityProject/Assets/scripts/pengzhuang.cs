using UnityEngine;
using System.Collections;

public class pengzhuang : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 碰撞相关的三个事件
	//碰撞开始
	void OnCollisionEnter (Collision other){
//		print ("enter");
	}

	//碰撞进行中
	void OnCollisionStay (Collision other){
		if (string.Equals(other.gameObject.name,"Cube")){
			print ("两个方块碰撞了");
		}
	}
	//碰撞结束
	void OnCollisionExit (Collision other){
//		print ("exit");
	}

	//触发器相关事件
	void OnTriggerEnter (Collider other){
		print ("开始触发");
	}

	void OnTriggerStay (Collider other){
		print ("出发中");
	}

	void OnTriggerExit (Collider other){
		print ("离开出发范围");
	}
}
