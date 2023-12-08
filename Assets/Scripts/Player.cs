using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    // Jump code
    // public Vector3 jump;
    // public float jumpForce = 3.0f;

    // public bool isGrounded;
    private bool canMove = true;
    private Rigidbody rb;
    
    [SerializeField] private Vector4 bounds;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float keyDelay = 0.2f; // Adjust the delay time as needed

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // void OnCollisionStay()
    // {
    //     isGrounded = true;
    // }

    private IEnumerator ResetMovementDelay()
    {
        yield return new WaitForSeconds(keyDelay);
        canMove = true;
    }

    private void Update()
    {
        Vector3 inputVector = new Vector3(0, 0, 0);

        // Move forward
        if (Input.GetKeyDown(KeyCode.W) && canMove && (transform.position.z + moveSpeed <= bounds.w))
        {
            inputVector.y = +1;
            canMove = false;
            StartCoroutine(ResetMovementDelay());
        }

        // Move backward
        if (Input.GetKeyDown(KeyCode.S) && canMove && (transform.position.z - moveSpeed >= bounds.z))
        {
            inputVector.y = -1;
            canMove = false;
            StartCoroutine(ResetMovementDelay());
        }

        // Move left
        if (Input.GetKeyDown(KeyCode.A) && canMove && (transform.position.x - moveSpeed >= bounds.x))
        {
            inputVector.x = -1;
            canMove = false;
            StartCoroutine(ResetMovementDelay());
        }

        // Move right
        if (Input.GetKeyDown(KeyCode.D) && canMove && (transform.position.x + moveSpeed <= bounds.y))
        {
            inputVector.x = +1;
            canMove = false;
            StartCoroutine(ResetMovementDelay());
        }
        // if (Input.GetKey(KeyCode.Space) && isGrounded)
        // {
        //     rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        //     isGrounded = false;
        // }

        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, inputVector.z, inputVector.y);
        transform.position += moveDir * moveSpeed;
    }
}