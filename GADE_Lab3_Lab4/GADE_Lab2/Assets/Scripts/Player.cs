using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// Simple ShootEmUp with trigger detection

public class Player : MonoBehaviour {

	Vector3 speed = new Vector3( 0.1f, 0.1f, 0.0f);
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}

	// collision
	/*
	void OnCollisionEnter(Collision collision) {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name,LoadSceneMode.Single);
	}
	*/

	private void OnTriggerEnter(Collider other) {
		Type type = other.gameObject.GetComponent<Type>();
		
		if (type != null && type.isDestroyable) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name,LoadSceneMode.Single);
		}
	}
		

	// Update is called once per frame
	void FixedUpdate () {
	
		Vector3 addToPosition = new Vector3 ();
		if (Input.GetKey("left")) {
			addToPosition.x = addToPosition.x - speed.x;
		}
		if (Input.GetKey("right")) {
			addToPosition.x = addToPosition.x + speed.x;
		}

		if (Input.GetKey("down")) {
			addToPosition.y = addToPosition.y - speed.y;
		}
		if (Input.GetKey("up")) {
			addToPosition.y = addToPosition.y + speed.y;
		}

		// pressure
		addToPosition.x = addToPosition.x + speed.x*2.0f;

		// move player here ... 
		GetComponent<Rigidbody>().MovePosition(transform.position + addToPosition);
	}

	void Update() {
		if (Input.GetKeyDown("space")) {
			Instantiate(bulletPrefab, transform.position + new Vector3(1.0f,0,0), transform.rotation);
		}
	}


}
