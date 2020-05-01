using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnim : MonoBehaviour
{
    public Animator Dino_Anim;

    public bool StopFlg=false;//

    public bool AttackFlg=false;
    public bool StoneFlg = false;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!StopFlg)       //攻撃してると入らない
        {

            if (Input.GetKeyUp(KeyCode.LeftArrow))  //はなすと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }


            else if (Input.GetKeyUp(KeyCode.RightArrow)) //はなすと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }


            else if (Input.GetKey(KeyCode.LeftArrow)
                      && Input.GetKey(KeyCode.RightArrow))//両方押すと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }


            else if (Input.GetKey(KeyCode.LeftArrow))      //左を押すと
            {
                Dino_Anim.SetBool("Run", true);     //走るモーション
            }


            else if (Input.GetKey(KeyCode.RightArrow))   //右を押すと
            {
                Dino_Anim.SetBool("Run", true);     //走るモーション
            }
        }
       



        if (Input.GetKeyDown("c"))              //押すと
        {
            if (Dino_Anim.GetCurrentAnimatorStateInfo(0).IsName("Dino_Attack_1"))
                Dino_Anim.SetBool("Attack_2", true);    //アタックモーション

            else if (Dino_Anim.GetCurrentAnimatorStateInfo(0).IsName("Dino_Attack_2"))
                     Dino_Anim.SetBool("Attack_3", true);    //アタックモーション

            else 
                     Dino_Anim.SetBool("Attack_1", true);    //アタックモーション

            AttackFlg = true;
        }
        if (Dino_Anim.IsInTransition(0))
        {
            AttackFlg = false;
        }
        if(AttackFlg==false)
        {
            Dino_Anim.SetBool("Attack_1", false);
            Dino_Anim.SetBool("Attack_2", false);
            Dino_Anim.SetBool("Attack_3", false);
        }


        if (Input.GetKeyDown("space"))              //押すと
        {
            Dino_Anim.SetBool("Stone", true);    //石拾いモーション
            StoneFlg = true;
        }
        if (Dino_Anim.GetCurrentAnimatorStateInfo(0).IsName("Dino_Stone_1"))
        {
            StoneFlg = false;
        }
        if (StoneFlg == false)
        {
            Dino_Anim.SetBool("Stone", false);
        }
    }
}
