using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : Enemy {
	private GameObject _player;
	
	void Start() {
		_player = GameObject.Find("Player");
	}

	public override void Behaviour() {
		Vector3 addToPosition = new Vector3();
		
		if (_player.transform.position.y < transform.position.y) {
			addToPosition = addToPosition + new Vector3(0.0f, -0.1f, 0.0f);
		}
		else {
			addToPosition = addToPosition + new Vector3(0.0f, 0.1f, 0.0f);
		}
		
		if (_player.transform.position.x < transform.position.x) {
			addToPosition = addToPosition + new Vector3(-0.1f, 0.0f, 0.0f);
		}
		else {
			addToPosition = addToPosition + new Vector3(0.1f, 0.0f, 0.0f);
		}

		GetComponent<Rigidbody>().MovePosition(transform.position + addToPosition);
	}
}
