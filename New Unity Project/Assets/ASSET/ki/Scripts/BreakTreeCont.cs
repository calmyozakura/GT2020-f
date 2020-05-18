using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTreeCont : MonoBehaviour
{
    public Animator BTree_anim;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Attack")
        {
          
           BTree_anim.SetBool("BreakFlg", true);
            
           

        }
    }
}
