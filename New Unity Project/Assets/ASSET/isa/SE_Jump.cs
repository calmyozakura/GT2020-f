using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Jump: MonoBehaviour
{
    private AudioSource[] sources;


    //GameObject player;

    bool SE_JUMP;//false ジャンプしていない
    bool Ground;//地面についたか

    float Axis_UD, Axis_LR, Axis2_UD, Axis2_LR; // Axis = 十字　Axis2 = アナログパッド
    void Start()
    {
        sources = gameObject.GetComponents<AudioSource>();

        SE_JUMP = false;Ground = false;
    }


    void Update()
    {
        Axis_LR = Input.GetAxis("DS4_L_CrossLR");
        Axis_UD = Input.GetAxis("DS4_L_CrossUD");

        Axis2_LR = Input.GetAxis("DS4_L_JoystickLR");
        Axis2_UD = Input.GetAxis("DS4_L_JoystickUD");

        if (Input.GetButton("DS4_Cross")
            || Axis_UD > 0 || Axis2_UD < 0
            || Input.GetKey(KeyCode.UpArrow)
            )
        {   Ground = false;

            if(SE_JUMP == false)//ジャンプの単発処理
            {
                sources[0].Play();
                SE_JUMP = true;
                
            }
           
        }

       
    }
    void OnCollisionEnter(Collision other) {

        SE_JUMP = false;

        if (Ground == false)//ジャンプの単発処理
        {
            sources[0].Play();
            Ground = true;
        }
    }
 
}
