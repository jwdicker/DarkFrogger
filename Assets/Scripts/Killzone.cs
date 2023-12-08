using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Spawnpoint;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("OoB"))
        {
            other.gameObject.transform.position = Spawnpoint;
            other.attachedRigidbody.velocity = Vector3.zero;
            other.attachedRigidbody.angularVelocity = Vector3.zero;
        }
       

    }
}
