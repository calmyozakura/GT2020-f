using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera6 : MonoBehaviour {

    public Vector3 offset;//キャラからの距離

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(offset.x, 0, offset.z);

        // transform.position = new Vector3(offset.x, 0, 0);

    }
}
