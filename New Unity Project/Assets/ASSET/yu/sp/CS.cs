using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS : MonoBehaviour {

    public CameraShake shake;
    private float waitTimer = 0;
    private bool hunka = false;

    private void Update()
    {
        
        if (hunka == true)
        {
             shake.Shake(0.5f, 0.5f);
             //hunka = false;
        }
    }

    void Hunka()
    {
        //if(hunka == false)
        //{
            
        //    hunka = true;
        //}
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HUnka")
        {
           
            hunka = true;
        }
        if (other.gameObject.tag == "HUnkaTmeru")
        {
           
            hunka = false;
        }
    }
}
