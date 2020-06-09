using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class methor : MonoBehaviour
{


    private float WaitTimer = 0;
    bool SE_BREAK = false;
    int s;
    public AudioSource[] sources;


    // Use this for initialization
    void Start()
    {
        //sources = gameObject.GetComponents<AudioSource>();
        sources[0].Play();
    }

    private void OnCollisionEnter(Collision other)
    {
        s++;
        sources[1].Play();
    }

}
