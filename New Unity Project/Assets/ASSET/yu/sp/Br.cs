using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Br : MonoBehaviour {

    //public AudioSource source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Yougan")
        {
            //source.Play();
            Destroy(gameObject);  
        }
    }

}
