using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texttrigger : MonoBehaviour {

    // Use this for initialization

    public Text dialogue;
    public string text;
    
    void OnTriggerEnter(Collider Col)
    {
        dialogue.text = text;
        Destroy(this.gameObject);
    }

}
