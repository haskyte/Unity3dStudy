using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour {
	private Animator _animator;

	private float speed = 2;
	private Vector3 target; //目标位置
	private bool isOver=true; //移动是否结束

	void Awake(){
		_animator = GetComponent<Animator> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			isOver = true;
			_animator.SetBool ("isRun",false);

			if (Input.GetKey (KeyCode.A)) {
				transform.Rotate (0, -1, 0);
			} 
			if (Input.GetKey (KeyCode.D)) {
				transform.Rotate (0, 1, 0);
			}
			if (Input.GetKey (KeyCode.W)) {
				_animator.SetBool ("isWalk",true);
				transform.Translate (0, 0, 1*Time.deltaTime);
			} 
			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (0, 0, -1*Time.deltaTime);
			}

			if (Input.GetKeyDown(KeyCode.Q)){
				// 播放攻击动画
				_animator.SetTrigger ("Attack");
				_animator.SetBool ("isWalk",false);
			}

			if (Input.GetKeyDown(KeyCode.R)){
				_animator.SetTrigger ("Skill");
			}

		}else{
			_animator.SetBool ("isWalk",false);
		}

		if (Input.GetMouseButtonDown(0)){
			//1. 获取鼠标点击时的目标位置
			// 创建射线
			// 从摄像机发射出一条经过鼠标当前位置的射线
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// 发射射线
			RaycastHit hitinfo = new RaycastHit ();
			if (Physics.Raycast (ray,out hitinfo)){
				// 获取碰撞点的位置
				if (hitinfo.collider.name == "Plane"){
					target = hitinfo.point;
					//					target.y = 0.5f;
					isOver = false;
					_animator.SetBool ("isRun",true);
				}
			}
		}

		//2. 让角色移动到目标位置
		MoveTo (target);
	}

	// 让角色移动到目标位置
	private void MoveTo(Vector3 tar){
		if (!isOver){
			Vector3 distances = tar - transform.position;
			transform.position += distances.normalized * speed * Time.deltaTime;
			transform.forward = distances.normalized;
			if (Vector3.Distance(transform.position,tar)<(0.2f)){
				isOver = true;
				transform.position = tar;
				_animator.SetBool ("isRun",false);
			}
		}
	}
}
