using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_AttackCont : MonoBehaviour
{
   

    public Animator Attack;
    public int Attakcount = 0;
    public bool Stopflg = false;
    public GameObject M_AttackPivot;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Stopflg)
        {
            Attakcount += 1;
            if (Attakcount >= 20)
            {
                Attakcount = 0;
                Stopflg = false;
                M_AttackPivot.gameObject.SetActive(false);
               
            }
            //if (Attakcount >= 200)
            //{
            //    M_AttackPivot.gameObject.SetActive(true);
            //    Attakcount = 0;
            //    Stopflg = false;
            //}
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "In")//岩に当たったら
        {
            Attack.SetFloat("AttackPara", 0.0f);//一時停止
                                                // Destroy(M_AttackPivot.gameObject, 1.0f);//デストロイ
            Stopflg = true;
        }
        //moveflg = true;  
    }
    //private void OnCollisionEnter(Collision other)
    //{

    //    if (other.gameObject.tag == "In")//岩に当たったら
    //    {
    //        Attack.SetFloat("AttackPara", 0.0f);//一時停止
    //                                            // Destroy(M_AttackPivot.gameObject, 1.0f);//デストロイ
    //        Stopflg = true;
    //    }
    //    //moveflg = true;  
    //}
}
