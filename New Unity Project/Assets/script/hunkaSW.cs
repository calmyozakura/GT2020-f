using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunkaSW : MonoBehaviour
{
   public bool hunkaFlg = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hunkaFlg = true;
        }
    }

    public bool honkaswitch()
    {
        return hunkaFlg;
    }
}
