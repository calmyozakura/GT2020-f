using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakrock_1 : MonoBehaviour
{
    public GameObject iwa;
    public GameObject part1;


    private Vector3 Iwa_posi;
    public Vector3 offset;

    public bool BreakFlg;

    // Use this for initialization
    void Start()
    {
        Iwa_posi = iwa.transform.position;
        BreakFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (BreakFlg == true)
        if (iwa == null && BreakFlg == false)//ストーンが壊れてれば
        {
            part1.gameObject.SetActive(false);
            part1.transform.position = Iwa_posi + offset;
            part1.gameObject.SetActive(true);//パーティクルをアクティブに

            BreakFlg = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Attack")//攻撃が当たると
        {
            Destroy(iwa.gameObject);//デストロイ
                                    //BreakFlg = true;


        }
        
        if (other.gameObject.tag == "Yougan")
        {

            Destroy(iwa.gameObject);//デストロイ
        }

    }
    void OnParticleCollision(GameObject other)
    {
        
        if (other.gameObject.tag == "Yougan")
        {

            Destroy(iwa.gameObject);//デストロイ
        }
    }
}
