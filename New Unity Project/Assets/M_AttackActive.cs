using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_AttackActive : MonoBehaviour
{
    public GameObject M_Attack;
    public int ActiveCount=0;
    public bool ActiveFlg;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (ActiveFlg)
        {
            if (!M_Attack.activeSelf)
            {
                ActiveFlg = false;

            }
        }
       
        if (!ActiveFlg)//非アクティブだったら
        {
            ActiveCount +=1;
            if(ActiveCount>=60)//３秒後に
            {
                M_Attack.gameObject.SetActive(true);//アクティブ
                ActiveCount = 0;
                ActiveFlg = true;
            }
        }
		
	}
}
