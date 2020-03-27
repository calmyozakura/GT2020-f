using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaCont : MonoBehaviour
{

    public Vector3 magmaSpeed;
    public Animator magma;
    // public GameObject M_Attack1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += magmaSpeed;

        //if (Stopflg)
        //{
        //    count += 1;
        //    if (count >= 60)
        //    {
        //        M_Attack1.gameObject.SetActive(false);
        //    }
        //    if (count >= 300)
        //    {
        //        M_Attack1.gameObject.SetActive(true);
        //        count = 0;
        //        Stopflg = false;
        //    }
        //}

        //   }
        //private void OnCollisionEnter(Collision other)
        //{

        //    if (other.gameObject.tag == "In")//岩に当たったら
        //    {
        //        magma.SetFloat("Atack1Para", 0.0f);//一時停止
        //        Stopflg = true;
        //    }
        //    //moveflg = true;  
        //}
    }
}
