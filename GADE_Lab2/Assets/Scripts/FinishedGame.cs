using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedGame : MonoBehaviour {
	private void OnTriggerEnter(Collider other) {
		if (SceneManager.GetActiveScene().name == "Stage1") {
			SceneManager.LoadScene("Stage2");
		}
		else if (SceneManager.GetActiveScene().name == "Stage2") {
			SceneManager.LoadScene("Stage1");
		}
	}
}
