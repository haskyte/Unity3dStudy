using UnityEngine;
using System.Collections;

public class rigidBodytest1 : MonoBehaviour {

	private Rigidbody r;
	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
		{
			//给当前游戏对象添加一个力
//			r.AddForce (new Vector3 (0f,10f,0));
			// 给对象添加扭矩、力矩
//			r.AddTorque (new Vector3(0f,10f,0f));
			//给物体指定的位置添加力
//			r.AddForceAtPosition (new Vector3 (0f, 10f, 0f), new Vector3 (0.5f,0.5f,0.5f));
//			在指定位置添加爆炸力
			r.AddExplosionForce (3000.0f, Vector3.zero, 4.0f);
		}
	}
}
