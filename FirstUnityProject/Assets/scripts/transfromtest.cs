using UnityEngine;
using System.Collections;

public class transfromtest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//获取当前脚本所挂载的游戏对象身上的 Transform组件
		// position 世界坐标系中的位置
		Vector3 pos = transform.position;
		print (pos);
		// localPosition 局部坐标系的位置
		Vector3 locPos = transform.localPosition;
		print (locPos);
		// 一般不修改四元数
//		transform.rotation;
//		transform.localRotation

		//
//		Vector3 scale = transform.localScale;

		// 控制游戏对象之间的父子关系
		// 获取当前游戏对象的父对象的transfrom 组件 transform.parent
		// 根对象 transform.root;

		//根据子对像名字获取当前对象的子对象 transform.Find ("Cube");
		//获取子对象   名字相同默认返回第一个 transform.FindChild ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
//			transform.position = Vector3.zero;
//			transform.localScale = new Vector3 (1f, 2f, 1f);

			//改变游戏对象的位置
//			transform.Translate (new Vector3 (0, 1, 0));
			// 旋转游戏对象
//			transform.Rotate (Vector3.up, 10f);
			// 欧拉角 属性
			transform.eulerAngles = new Vector3 (0f, 45f, 0f);
		}
	}
}
