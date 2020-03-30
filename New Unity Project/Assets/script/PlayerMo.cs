using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMo : MonoBehaviour {


    public float vector = 0.1f;
    public float vector2 = 0.1f;
    bool  Yoin = false;
   public bool Iswitch = false;
    public float playerU = 0;

    //public bool JumpState = false; //２段以上のジャンプ防止



    SpriteRenderer Dinasor; //恐竜の画像
    float Axis_UD, Axis_LR, Axis2_UD,Axis2_LR; // Axis = 十字　Axis2 = アナログパッド



    void Start () {
        this.Dinasor = GetComponent<SpriteRenderer>();
        Dinasor.flipX = true;
    }
	
	// Update is called once per frame
	void Update () {
        //キーボード
        if (Input.GetKey(KeyCode.UpArrow))//上
        {
            this.transform.position += new Vector3(0, +vector2, 0);
            playerU = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//左
        {
            this.transform.position += new Vector3(-vector,0, 0);
            playerU = 2;
            Dinasor.flipX = false;
            //  this.transform.localScale = new Vector3(-1, 1, 1);
        }
        else  if (Input.GetKey(KeyCode.RightArrow))//右
        {
            playerU = 3;
            this.transform.position += new Vector3(+vector,0, 0);
            Dinasor.flipX = true;
            // this.transform.localScale = new Vector3(1, 1, 1);
        }



        //十字&左アナログパッド、両方の軸を取得
        Axis_LR = Input.GetAxis("DS4_L_CrossLR");
        Axis_UD = Input.GetAxis("DS4_L_CrossUD");

        Axis2_LR = Input.GetAxis("DS4_L_JoystickLR");
        Axis2_UD = Input.GetAxis("DS4_L_JoystickUD");

        //コントローラー
        if (Input.GetButton("DS4_Cross") || (Axis_UD > 0 || Axis2_UD < 0))//上
        {
            this.transform.position += new Vector3(0, +vector, 0);
            playerU = 1;
        }

        if( Axis_LR < 0 || Axis2_LR < 0)//左
        {
            this.transform.position += new Vector3(-vector, 0, 0);
            playerU = 2;
            Dinasor.flipX = false;
            //  this.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Axis_LR > 0 || Axis2_LR > 0)//右
        {
            playerU = 3;
            this.transform.position += new Vector3(+vector, 0, 0);
            Dinasor.flipX = true;
            // this.transform.localScale = new Vector3(1, 1, 1);
        }


        if (Yoin == true)
        {
            YOIN();
        }
    }

    void OnCollisionStay(Collision collision)
        {
        if (collision.gameObject.tag == "Speed")
        {
            Debug.Log("a");
            // this.transform.position += new Vector3(100, 0, 0);
            vector = 0.5f;
        }
      
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Speed")
        {
            Debug.Log("b");
            Yoin = true;
        }
    }
   void  YOIN()
    {
            if (vector <= 0.2f)
            {
                Yoin = false;
            }
            else
        {
            Debug.Log(vector);
            vector -= 0.01f;
        }
    }

     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Line"))
        {
            Iswitch = true;
        }
    }

    public bool Insekiswitch()
    {
        return Iswitch;
    }
}
