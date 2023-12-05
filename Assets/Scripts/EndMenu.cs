using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Replaygame(){ 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
