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
    }

    /*
     * have direction
     * have speed
     * have distance for spawning
     * 
     */
    [SerializeField] private int direction = 1;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float wrapDistance = 30f;
    // Update is called once per frame
    void Update(){
        Vector3 moveDir = new Vector3(1, 0, 0);
        transform.position += moveDir * Time.deltaTime * speed;
        if(transform.position.x >= startPosition.x + wrapDistance) {
            transform.position = startPosition;
        }
    }
}
