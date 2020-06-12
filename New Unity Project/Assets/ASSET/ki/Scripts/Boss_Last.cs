using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLast : MonoBehaviour
{
    GameObject Bossson;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")//水に落ちると
        {
            
                                    //BreakFlg = true;


        }

    }
}
