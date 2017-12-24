using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenetrigger : MonoBehaviour {


    public int sceneNumber;


    void OnTriggerEnter(Collider Col)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNumber);
    }
}
