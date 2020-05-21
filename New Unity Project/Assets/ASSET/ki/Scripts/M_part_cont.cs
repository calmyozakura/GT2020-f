using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_part_cont : MonoBehaviour
{
    public GameObject Dino;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Dino == null)
        {
            this.gameObject.SetActive(true);
        }
    }

   
}
