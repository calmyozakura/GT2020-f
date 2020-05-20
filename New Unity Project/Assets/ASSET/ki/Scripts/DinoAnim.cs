using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnim : MonoBehaviour
{
    public Animator Dino_Anim;

    public bool StopFlg=false;//

    public bool AttackFlg=false;
    public bool StoneFlg = false;

    bool jump;
    bool hit;

    AudioSource source;
    public AudioClip clip;

    float Axis_LR, Axis_UD, Axis2_LR, Axis2_UD;//十字キー 及び 左スティック の 軸の取得
    　
    // Use this for initialization
    void Start ()
    {
        jump = true; hit = true;
    }
	
	// Update is called once per frame
	void Update ()

    {
        if (Input.GetButton("DS4_Cross") || (Axis_UD > 0 || Axis2_UD < 0))
        {
            jump = false;
        }

        if (!StopFlg)       //攻撃してると入らない
        {

            //十字&左アナログパッド、両方の軸を取得
            Axis_LR = Input.GetAxis("DS4_L_CrossLR");
            Axis_UD = Input.GetAxis("DS4_L_CrossUD");

            Axis2_LR = Input.GetAxis("DS4_L_JoystickLR");
            Axis2_UD = Input.GetAxis("DS4_L_JoystickUD");

            if (Input.GetKeyUp(KeyCode.LeftArrow))  //はなすと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }


            else if (Input.GetKeyUp(KeyCode.RightArrow)) //はなすと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }

            else if (Axis_LR == 0&& Axis2_LR == 0) //はなすと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }
            else if (Input.GetKey(KeyCode.LeftArrow)
                      && Input.GetKey(KeyCode.RightArrow)||jump == false)//両方押すと
            {
                Dino_Anim.SetBool("Run", false);    //止まるモーション
            }


            else if (Input.GetKey(KeyCode.LeftArrow)
                || Axis_LR  < 0 
                || Axis2_LR < 0)      //左を押すと
            {
                Dino_Anim.SetBool("Run", true);     //走るモーション
            }


            else if (Input.GetKey(KeyCode.RightArrow)
                || Axis_LR  > 0 
                || Axis2_LR > 0)   //右を押すと
            {
                Dino_Anim.SetBool("Run", true);     //走るモーション
            }
        }

        


        if (Input.GetKeyDown("c")||Input.GetButton("DS4_Circle"))              //押すと
        {
            if (Dino_Anim.GetCurrentAnimatorStateInfo(0).IsName("Dino_Attack_1"))
                Dino_Anim.SetBool("Attack_2", true);    //アタックモーション

            else if (Dino_Anim.GetCurrentAnimatorStateInfo(0).IsName("Dino_Attack_2"))
                     Dino_Anim.SetBool("Attack_3", true);    //アタックモーション

            else 
                     Dino_Anim.SetBool("Attack_1", true);    //アタックモーション

            AttackFlg = true;

            if(hit == true)//音声単発処理
            {
                hit = false;
                source.PlayOneShot(clip, 1);
            }
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

        if (!Input.GetButton("DS4_Circle"))
        {
            hit = true;
        }

        if (Input.GetKeyDown("space")||Input.GetButton("DS4_Triangle"))              //押すと
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
