using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnim : MonoBehaviour
{
    public Animator Dino_Anim;

    public bool StopFlg;//止めるためのフラグ

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
            Dino_Anim.SetBool("Attack_1", true);    //アタックモーション
            
        }

    }
}
