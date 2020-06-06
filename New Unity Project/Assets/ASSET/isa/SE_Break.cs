using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Break : MonoBehaviour {


    private float WaitTimer = 0;
    bool SE_BREAK=false;
    int s;
    public AudioSource[] sources;


	// Use this for initialization
	void Start () {
        //sources = gameObject.GetComponents<AudioSource>();
        s = 0;
	}

    private void OnTriggerStay(Collider other)
    {

        if (this.gameObject.tag == "Stone")
            if (other.gameObject.tag == "Player")
            {
                 if (Input.GetKey(KeyCode.C)
                  || Input.GetButton("DS4_Circle"))
                 {
                    sources[0].Play();
                 }
            }

        
        
            if (other.gameObject.tag == "Player"&&s==0)
            {
                if (Input.GetKey(KeyCode.C)
                 || Input.GetButton("DS4_Circle"))
                {
                    if (++WaitTimer / 6 == 2)
                    {
                       sources[s].Play();
                        WaitTimer = 0;s = 1;
                    }
                }
            
            }


    }
   
}
