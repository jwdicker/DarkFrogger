using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Jump code
[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour {
    
    //jump
    public Vector3 jump;
    public float jumpForce = 3.0f;

    public bool isGrounded;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay(){
        isGrounded = true;
    }

    [SerializeField] private float moveSpeed = 7f;
    private void Update() {
        // Vector2 inputVector = new Vector2(0, 0);
        Vector3 inputVector = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.W)) {
            inputVector.y = +1;
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            inputVector.y = -1;
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            inputVector.x = -1;
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            inputVector.x = +1;
        }
        if (Input.GetKey(KeyCode.Space)&& isGrounded){
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, inputVector.z, inputVector.y);
        transform.position += moveDir * moveSpeed *  Time.deltaTime;
        // Debug.Log(inputVector);
    }
}