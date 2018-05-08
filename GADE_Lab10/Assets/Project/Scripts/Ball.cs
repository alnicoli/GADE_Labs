using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject gameManager;
	public bool falling = false;

	private float previousHeight;

	void LateUpdate() {
		float currentheight = gameObject.transform.position.y;

		float travel = currentheight - previousHeight;
		previousHeight = currentheight;

		if (travel <= 0) {
			falling = true;
		}
		else {
			falling = false;
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (falling) {
			gameManager.GetComponent<GameManager>().Score();
		}
	}
	

}
