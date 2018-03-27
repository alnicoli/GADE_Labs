using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void Quit() {
		Application.Quit();
	}

	public void Play() {
		SceneManager.LoadScene("ingame", LoadSceneMode.Single);
	}
	
	public void Menu() {
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
