using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Break : MonoBehaviour {

    bool SE_BREAK=false;

    public AudioSource[] sources;

	// Use this for initialization
	void Start () {
		//sources = gameObject.GetComponents<AudioSource>();
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.C)
             || Input.GetButton("DS4_Circle"))
            {
                sources[0].Play();
                
            }
        }
    }
}
