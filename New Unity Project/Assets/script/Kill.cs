using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

	

    // Update is called once per frame
    void Update () {
        //Destroy(gameObject.transform.Find("Player").gameObject);
        //Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {   
            Destroy(other.gameObject);
        }
       
    }
}
