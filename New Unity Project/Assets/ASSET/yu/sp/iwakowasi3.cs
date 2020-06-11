using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iwakowasi3 : MonoBehaviour {

    private float WaitTimer = 0;
    public int iwakowasi;
    public bool iwa;
    public GameObject part1;
    void Start()
    {
        iwakowasi = 3;
    }

    void Update()
    {
        //float fps = 1f / Time.deltaTime;
        //Debug.LogFormat("{0}fps", fps);



        if (iwa == true)
        {
            //  part.gameObject.SetActive(true);

        }

        iwa = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Stone2")
        {
            if (Input.GetKey(KeyCode.C)
              || Input.GetButton("DS4_Circle"))
            {
                if (++WaitTimer / 6 == 2)
                {
                    part1.gameObject.SetActive(true);
                    iwakowasi -= 1;
                    WaitTimer = 0;
                    iwa = true;
                }
            }
            if (iwakowasi <= 0)
            {
                Debug.Log(iwakowasi);
                Destroy(other.gameObject);
                iwakowasi = 3;
            }
        }
    }
}
