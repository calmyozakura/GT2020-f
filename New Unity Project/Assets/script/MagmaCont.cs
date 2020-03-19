using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaCont : MonoBehaviour {

    public Vector3 magmaSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += magmaSpeed;

    }
}
