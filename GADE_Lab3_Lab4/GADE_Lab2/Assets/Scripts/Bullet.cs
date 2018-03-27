using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Bullet : MonoBehaviour {	
	float destroyTime = 2.0f;

	void FixedUpdate () {
		GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(1.0f,0,0));
	}

	private void OnTriggerEnter(Collider other) {
		Type type = other.gameObject.GetComponent<Type>();
		Enemy enemyComponent = other.gameObject.GetComponent<Enemy>();
		
		if (type != null && type.isDestroyable) {
			if (enemyComponent != null) {
				enemyComponent.BeKilled();
			}
			Destroy(gameObject);
		}
		
		

		if (enemyComponent != null) {
			if (!enemyComponent) {
				
			}
		}
	}

	private void Update() {
		Destroy(gameObject, destroyTime);
	}
}
