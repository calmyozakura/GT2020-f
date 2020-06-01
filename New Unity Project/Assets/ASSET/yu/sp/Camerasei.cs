using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerasei : MonoBehaviour {

    [SerializeField] private GameObject Cameratmp;
    
    Vector3 tmp;
    CameraCONT script;

    // Use this for initialization
    void Start () {
        script = Cameratmp.GetComponent<CameraCONT>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する   
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            script.moveflagfalse();
        }
    }
}
