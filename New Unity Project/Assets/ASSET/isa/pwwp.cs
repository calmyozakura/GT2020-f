using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwwp : MonoBehaviour {

    AudioSource[] sources;

	// Use this for initialization
	void Start () {
        sources = this.gameObject.GetComponents<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
                    sources[0].Play();                
            
        }
    }
}
