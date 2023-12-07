using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("end", LoadSceneMode.Single);
    }
}
