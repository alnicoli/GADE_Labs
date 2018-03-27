using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySinus : Enemy {
	private GameObject _player;
	
	void Start() {
		_player = GameObject.Find("Player");
	}

	public override void Behaviour() {
		GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(-0.05f,Mathf.Sin(Time.time * 1.5f) * 0.15f, 0));
	}
}


