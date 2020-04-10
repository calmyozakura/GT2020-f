using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource[] sources;

    bool jumpflg;

    //GameObject player;

    bool SE_JUMP;//false ジャンプしていない

    float Axis_UD, Axis_LR, Axis2_UD, Axis2_LR; // Axis = 十字　Axis2 = アナログパッド
    void Start()
    {
        sources = gameObject.GetComponents<AudioSource>();

        SE_JUMP = false;
    }


    void Update()
    {
        Axis_LR = Input.GetAxis("DS4_L_CrossLR");
        Axis_UD = Input.GetAxis("DS4_L_CrossUD");

        Axis2_LR = Input.GetAxis("DS4_L_JoystickLR");
        Axis2_UD = Input.GetAxis("DS4_L_JoystickUD");

        if (Input.GetButtonDown("DS4_Cross")
            || (Axis_UD > 0 || Axis2_UD < 0)
            || Input.GetKey(KeyCode.UpArrow)
            )
        {

            if(SE_JUMP == false)//ジャンプの単発処理
            {
                sources[0].Play();
                SE_JUMP = true;
            }
           
        }

       
    }
    void OnCollisionEnter(Collision other) {

        SE_JUMP = false;
    }
 
}
