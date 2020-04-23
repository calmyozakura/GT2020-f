using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAKAZATO3 : MonoBehaviour
{
    private float WaitTimer=0;
    public int nakazato;
    public bool iwa;
    public GameObject part1;
    void Start()
    {
        nakazato = 3;
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
              ||Input.GetButton("DS4_Circle"))
            {
                if (++WaitTimer / 6 == 2)
                {
                    part1.gameObject.SetActive(true);
                    nakazato -= 1;
                    WaitTimer = 0;
                    iwa = true;
                }
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
