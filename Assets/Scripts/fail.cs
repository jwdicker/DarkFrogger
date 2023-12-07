using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fail : MonoBehaviour
{
   public void StartGame(){ 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
