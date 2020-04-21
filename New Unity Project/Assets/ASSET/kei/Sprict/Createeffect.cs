using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createeffect : MonoBehaviour {

    public GameObject OB;
    public GameObject fire;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OB == null) fire.gameObject.SetActive(true);
    }
}
