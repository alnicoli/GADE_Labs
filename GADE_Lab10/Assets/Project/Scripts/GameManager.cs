using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public int points;
	public int shotsLeft = 10;
	public GameObject pointsUI;
	public GameObject shotsUI;

	// Use this for initialization
	void Start () {
		points = 0;
		UpdateUi();
	}

	public void Score() {
		points += 1;
		UpdateUi();
	}

	public void ResetPoints() {
		points = 0;
		UpdateUi();
	}
	
	public void DecreaseShotsLeft() {
		shotsLeft -= 1;

		if (shotsLeft == 0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		UpdateUi();
	}

	private void UpdateUi() {
		pointsUI.GetComponent<Text>().text = "Points: " + points.ToString();
		shotsUI.GetComponent<Text>().text = "Shots left: " + shotsLeft.ToString();
	}
}
