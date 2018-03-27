using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _vx = 0.0f;
    private float _vy = 0.0f;

    // Use this for initialization
    void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        _vy = _vy - 0.0003f;
        
        if (Input.GetKey("right")) {
            _vx = _vx + 0.001f;
        }
        if (Input.GetKey("left")) {
            _vx = _vx - 0.001f;
        }
        if (Input.GetKey("up")) {
            _vy = _vy + 0.001f;
        }
        if (Input.GetKey("down")) {
            _vy = _vy - 0.001f;
        }

        Vector3 newPosition = transform.position;

        newPosition = newPosition + new Vector3(_vx, _vy, 0.0f);

        _rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter(Collision other) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}