using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILL : MonoBehaviour {

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
