using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nakazato : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Stone")
        {
            if (Input.GetKey(KeyCode.C))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
