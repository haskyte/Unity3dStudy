
using UnityEngine;
using System.Collections;

public class mouseAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//鼠标事件
	// 1.点击鼠标
	void OnMouseDown(){
		print ("mouse down");
	}
	//2. 松开鼠标的时候调用
	void OnMouseUp(){
		print ("mouse up");
	}

	// 3.当鼠标持续按下左键时调用
	void OnMouseDrag(){
		print ("drag");
	}
	// 4.鼠标移动到gameobject时候调用
	void OnMouseEnter(){
		print ("enter");
	}
	// 5. 鼠标离开时候调用
	void OnMouseExit(){
		print ("Exit");
	}

	//6. 鼠标放在上面的时候调用
	void OnMouseOver(){
		print ("over");
	}
	//7. 像点击按钮一样点击游戏对象
	void OnMouseUpAsButton(){
		print ("Up As Button");
	}
}
