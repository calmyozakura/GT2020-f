using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAKAZATO : MonoBehaviour {

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
