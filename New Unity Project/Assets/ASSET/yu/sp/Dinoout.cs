using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinoout : MonoBehaviour {

    public float vector;
    public float vector2;
    private bool migi = false;
    private bool Jp = false;
    private float waitTimer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.position += new Vector3(+vector, 0, 0);

    }
    //void FixedUpdate()
    //{




    //}
}
