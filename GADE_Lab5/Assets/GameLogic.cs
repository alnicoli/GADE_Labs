using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	public Text pillText;
	private int totalPills;
	
	// Use this for initialization
	void Start () {
		pillText.text = "No pills";
		totalPills = GameObject.Find("Pills").transform.childCount;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject pills = GameObject.Find("Pills");
		Debug.Log(pills);
		if (pills.transform.childCount != 0) {
			int pillsAmount = pills.transform.childCount;
			pillText.text = totalPills - pillsAmount + " pills collected";
		}
		else {
			GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
			GameObject.Find("Canvas").transform.GetChild(1).gameObject.SetActive(true);
		}
	}
}
