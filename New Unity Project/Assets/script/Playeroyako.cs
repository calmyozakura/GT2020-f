using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeroyako : MonoBehaviour {

	// Use this for initialization
	void Start () {
       transform.parent = GameObject.Find("MoveFloor").transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
