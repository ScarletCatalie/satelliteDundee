using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTrigger : MonoBehaviour
{

	public float teleportx = 16.0f;
	public float teleporty = 0.0f;
	public float teleportz = 37.5f;

    public GameObject PlayerCont;

        void OnTriggerEnter(Collider Col)
        {
            PlayerCont.transform.position = new Vector3(16.0f, 0.0f, 37.5f);
         }
    }
