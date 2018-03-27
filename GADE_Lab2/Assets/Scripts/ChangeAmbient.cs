using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAmbient : MonoBehaviour {
	private bool _changing = false;
	private float _step = 0.001f;
	private float _darkness = 0.3f;
	
	private void Update() {
		if (_changing) {
			if (RenderSettings.ambientIntensity < _darkness) {
				RenderSettings.ambientIntensity = _darkness;
				_changing = false;
			}
			else {
				RenderSettings.ambientIntensity = RenderSettings.ambientIntensity - _step;
			}
		}
	}
	
	void OnTriggerEnter(Collider other) {
		_changing = true;
	}
}
