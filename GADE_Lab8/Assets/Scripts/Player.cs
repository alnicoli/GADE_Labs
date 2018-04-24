using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject activateOnWon;
	public AudioClip scream;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = scream;
	}

	void OnTriggerEnter(Collider other) {
		GetComponent<AudioSource> ().Play ();
		StartCoroutine("Restart");
	}
	
	IEnumerator Restart()
	{
		yield return new WaitForSeconds(2);
		Application.LoadLevel(0);
	}
}
