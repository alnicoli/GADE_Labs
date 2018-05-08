using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	
	// GameManager
	public GameObject gameManager;

	// Gameobject
	public GameObject ball;
	public GameObject playerCamera;
	
	// UI
	public GameObject forceSlider;
	
	// Variables
	public float ballDistanceForward = 2.3f;
	public float ballDistanceDown = -0.5f;
	public float ballThrowForce = 0f;
	public float maxThrowForce = 2000f;
	
	private bool holding = false;

	// Components
	private Rigidbody ballRb;
	private Slider slider;

	void Start () {
		ballRb = ball.GetComponent<Rigidbody>();
		ballRb.useGravity = false;
		slider = forceSlider.GetComponent<Slider>();
		slider.value = 0;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			if (ballRb.useGravity) {
				ballRb.useGravity = false;
				ballRb.angularVelocity = Vector3.zero;
				ballRb.velocity = Vector3.zero; 
				ball.transform.rotation = Quaternion.identity;
			}
			holding = true;
		}
		
		if (holding) {
			ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistanceForward + playerCamera.transform.up * ballDistanceDown;

			if (Input.GetMouseButton(0)) {
				if (ballThrowForce < 2000f) {
					ballThrowForce += 20f;
					slider.value = GetSliderValue();
				}
				else {
					ballThrowForce = maxThrowForce;
				}
			}
			
			if (Input.GetMouseButtonUp(0)) {
				holding = false;
				ballRb.useGravity = true;
				ballRb.AddForce(playerCamera.transform.forward * ballThrowForce);
				ballThrowForce = 0f;
				slider.value = 0;
				gameManager.GetComponent<GameManager>().DecreaseShotsLeft();
			}
		}
	}

	float GetSliderValue() {
		return 100 / maxThrowForce * ballThrowForce / 100;
		
	}
}
