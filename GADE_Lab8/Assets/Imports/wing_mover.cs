using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing_mover : MonoBehaviour {

	bool wingsExtended = true;
	GameObject leftWing;
	GameObject rightWing;
	Vector3 positionOfDog;

	// Use this for initialization
	void Start () {
		leftWing = this.transform.Find ("LeftWing").gameObject;
		rightWing = this.transform.Find ("RightWing").gameObject;
		positionOfDog = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		positionOfDog = this.transform.position;
		if (Input.GetKeyDown("space")) {
			if (wingsExtended) {
				leftWing.transform.RotateAround (positionOfDog, Vector3.forward, -90);
				rightWing.transform.RotateAround (positionOfDog, Vector3.forward, +90);
				wingsExtended = false;
			} else {
				leftWing.transform.RotateAround (positionOfDog, Vector3.forward, 90);
				rightWing.transform.RotateAround (positionOfDog, Vector3.forward, -90);
				wingsExtended = true;
			}
		}
	}

}
