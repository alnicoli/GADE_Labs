using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform _playerTransform;
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = _playerTransform.position;        
		transform.position = new Vector3(targetPos.x + 30, transform.position.y, transform.position.z);
	}
}
