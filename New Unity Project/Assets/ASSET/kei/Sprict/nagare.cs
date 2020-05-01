using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagare : MonoBehaviour {

    [SerializeField] private GameObject tmp;

    G script;

    // Use this for initialization
    void Start () {
        script = tmp.GetComponent<G>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            script.rb.isKinematic = false;
            
        }
    }

}
