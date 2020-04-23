using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAKAZATO : MonoBehaviour {

    public int nakazato;

    void Start()
    {
        nakazato = 3;
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
              ||Input.GetButton("DS4_Circle"))
            {
                nakazato -= 1;
                
            }
            if (nakazato <= 0)
            {
                Debug.Log(nakazato);
                Destroy(other.gameObject);
                nakazato = 3;
            }
        }
    }
}
