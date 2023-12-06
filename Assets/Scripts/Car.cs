using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Vector3 startPosition = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position; //initialize a starting position to spawn from
        // helps with finding which y and z to stay in when respawning the car
    }

    /*
     * have direction
     * have speed
     * have distance for spawning
     */

    [SerializeField] private float directionalSpeed = 10f;
    [SerializeField] private float rightDistanceBound = 30f;
    [SerializeField] private float leftDistanceBound = 0f;

    // private Vector3 spawnPosition = new Vector3()
    // Update is called once per frame
    void Update(){
        Vector3 moveDir = new Vector3(1, 0, 0);
        transform.position += moveDir * Time.deltaTime * directionalSpeed;
        if (directionalSpeed > 0) {
            if (transform.position.x >= rightDistanceBound) {
                transform.position = new Vector3(leftDistanceBound, startPosition.y, startPosition.z);
            }
        }
        else {
            if(transform.position.x <= leftDistanceBound) {
                transform.position = new Vector3(rightDistanceBound, startPosition.y, startPosition.z);
            }
        }   
    }
}