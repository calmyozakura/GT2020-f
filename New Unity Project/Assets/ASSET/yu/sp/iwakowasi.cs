using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iwakowasi : MonoBehaviour {

    public int iwaKOwasi;

    void Start()
    {
        iwaKOwasi = 3;
    }

    void Update()
    {
        //float fps = 1f / Time.deltaTime;
        //Debug.LogFormat("{0}fps", fps);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Stone")
        {
            if (Input.GetKey(KeyCode.C)
              || Input.GetButton("DS4_Circle"))
            {
                iwaKOwasi -= 1;

            }
            if (iwaKOwasi <= 0)
            {
                Debug.Log(iwaKOwasi);
                Destroy(other.gameObject);
                iwaKOwasi = 3;
            }
        }
    }
}
