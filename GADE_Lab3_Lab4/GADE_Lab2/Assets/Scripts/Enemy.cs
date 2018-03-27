using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {	
	// Update is called once per frame
	void FixedUpdate () {
		Behaviour();
	}

	public virtual void BeKilled() {
		print("Be killed");
		Destroy(gameObject);
	}

	public virtual void Behaviour() {
	}
}
