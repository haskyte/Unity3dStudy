using UnityEngine;
using System.Collections;



//	继承于 MonoBehaviour 的类叫做运行时类
//	运行时类不能手动实例化
public class life : MonoBehaviour {

	// 脚本被 加载 时候调用 不是激活状态也会调用
	// 做一些初始化操作
	void Awake () {
		print ("Awake");
	}
//	每次激活脚本都会调用
	void OnEnable () {
		print ("OnEnable");
	}

	// 第一次调用update之前调用一次
	void Start () {
		print ("Start");
	}
	
	// 每帧调用一次update
	void Update () {
		print ("Update");
	}
	// 在update方法调用完之后调用
	void LateUpdate () {
		print ("LateUpdate");
	}
	// 取消激活状态后调用
	void OnDisable () {
		print ("OnDisable");
	}
	// 被销毁时候调用
	void OnDestroy () {
		print ("OnDestroy");
	}

	// 持续调用 -IMGUI 代码需要写在OnGUI方法中
	void OnGUI () {
		print ("OnGUI");
	}

	// 以固定的频率调用，不会受到图像刷新帧速率的影响
	// 一般会把处理物理的代码放在这里
	void FixedUpdate () {
		print ("FixedUpdate");
	}
}
