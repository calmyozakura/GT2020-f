using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYERMO : MonoBehaviour
{
    private float rotate2;
    
    public float Speed;
    public float vector;
    public float vector2;
    bool Yoin = false;
    private bool Iswitch = false;
    public float playerU = 0;
    private bool grabflg = false;
    private bool MagumaSPD = false;

    private float waitTimer = 0;
    private bool ITEMflg = false;
    public bool Mutekiflg = false;
    private bool Jumpflg = false;
    private bool spiderflg = false;
    private bool Sousa = false;         //プレイヤー操作のフラグ

    public int suuti = 0;
    //public bool JumpState = false; //２段以上のジャンプ防止
    //private Stone Stone;

    //SpriteRenderer Dinasor; //恐竜の画像
    float Axis_UD, Axis_LR, Axis2_UD, Axis2_LR; // Axis = 十字　Axis2 = アナログパッド

    private Vector3 Position;


    public AudioClip clip;
    AudioSource source;

    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();//再生オブジェクト特定
        //    this.Dinasor = GetComponent<SpriteRenderer>();
        //    Dinasor.flipX = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(vector);

        // transformを取得
        Transform myTransform = this.transform;

        //Position.Rotate = new Vector3(0, rotate2, 0);           //プレイヤー回転
        transform.Rotate(new Vector3(0, rotate2, 0));


        if (ITEMflg == true)
        {
            if (++waitTimer / 6 == 24)
            {
                //Debug.Log("batauysaibjacj,xjalkcnkjnaxjc");
                vector = 0.3f;
                ITEMflg = false;
            }
        }

        if (Mutekiflg == true)
        {
            if (++waitTimer / 6 == 180)
            {
                Debug.Log("muteki");
                Mutekiflg = false;
            }
        }
        if (Jumpflg == true)
        {
            if (++waitTimer / 6 == 30)
            {
                Debug.Log("JumpUP");
                Jumpflg = false;
                vector2 = 0.17f;
            }
        }

        if (spiderflg == true)
        {
            if (++waitTimer / 6 == 30)
            {
                Debug.Log("spider");
                spiderflg = false;
                vector = 0.3f;
            }
        }
        if (Sousa == true)
        {
            this.transform.position += new Vector3(+vector, 0, 0);

            if (++waitTimer / 6 == 60)
            {
                switch (suuti)
                {
                    case 0:
                        break;
                    case 1:
                        SceneL();
                        break;
                    case 2:

                        break;
                }
             //   SceneManager.LoadScene("Stage2");

                Sousa = false;
            }
        }
        if (Sousa == false) {
            //キーボード
            if (Input.GetKey(KeyCode.UpArrow))//上
            {
                this.transform.position += new Vector3(0, +vector2, 0);
                //playerU = 1;
            }
            if (Input.GetKey(KeyCode.LeftArrow))//左
            {
                //if (playerU == 3 || playerU == 0)
                //{
                //    transform.Rotate(new Vector3(0, 180, 0));
                //}
                this.transform.position += new Vector3(-vector, 0, 0);
                //playerU = 2;
                //Dinasor.flipX = false;
                //  this.transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (Input.GetKey(KeyCode.RightArrow))//右
            {
                //if (playerU == 2)
                //{
                //    transform.Rotate(new Vector3(0, 180, 0));
                //}
                //playerU = 3;
                this.transform.position += new Vector3(+vector, 0, 0);
                //Dinasor.flipX = true;
                // this.transform.localScale = new Vector3(1, 1, 1);
            }
        }


        //十字&左アナログパッド、両方の軸を取得
        Axis_LR = Input.GetAxis("DS4_L_CrossLR");
        Axis_UD = Input.GetAxis("DS4_L_CrossUD");

        Axis2_LR = Input.GetAxis("DS4_L_JoystickLR");
        Axis2_UD = Input.GetAxis("DS4_L_JoystickUD");

        //コントローラー
        if (Input.GetButton("DS4_Cross") || (Axis_UD > 0 || Axis2_UD < 0))//上
        {
            this.transform.position += new Vector3(0, +vector2, 0);
            playerU = 1;
        }

        if (Axis_LR < 0 || Axis2_LR < 0)//左
            
        {
            //if (playerU == 3 || playerU == 0)
            //{
            //    transform.Rotate(new Vector3(0, 180, 0));
            //}
            this.transform.position += new Vector3(-vector, 0, 0);
            //playerU = 2;
            //Dinasor.flipX = false;
            //  this.transform.localScale = new Vector3(-vector, 1, 1);
        }
        else if (Axis_LR > 0 || Axis2_LR > 0)//右
            
        {
            //if (playerU == 2)
            //{
            //    transform.Rotate(new Vector3(0, 180, 0));
            //}
            //playerU = 3;
            this.transform.position += new Vector3(+vector, 0, 0);
            //Dinasor.flipX = true;
            // this.transform.localScale = new Vector3(1, 1, 1);
        }


        if (Yoin == true)
        {
            YOIN();
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
    void YOIN()
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

   void OnCollisionStay(Collision other)
   {

     if (other.gameObject.tag == "Speed")
       {

        MagumaSPD = true;
       }
   }


    //void OnTriggerStay(Collider other)
    //{
    //    if(other.gameObject.tag == "spider")
    //    {
    //        vector *= Speed;
    //    }  
    //}
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "spider")
    //    {
    //        vector = 0.3f;

    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpeedItem" && ITEMflg == false)
        {
            Destroy(other.gameObject);
            vector += 0.2f;
            waitTimer = 0;
            ITEMflg = true;
        }
        /***********************************************
         ******* スターの処理
         ******************************************************/
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
            waitTimer = 0;
            Mutekiflg = true;
        }
        if (other.gameObject.tag == "Stone3" && Mutekiflg == true)
        {
          //  AudioSource.PlayClipAtPoint(clip, transform.position);//一時的に残留してオブジェクトを再生する

            Destroy(other.gameObject);
        }
        /**********************************************************/
        if (other.gameObject.tag == "JumpUP")
        {
            Destroy(other.gameObject);
            waitTimer = 0;
            vector2 += 0.3f;
            Jumpflg = true;
        }
        if (other.gameObject.tag == "spider" && spiderflg == false)
        {
            vector = 0.2f;
            waitTimer = 0;
            spiderflg = true;
        }

    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Stop")
        {
            suuti += 1;
            Sousa = true;
        }
    }
    public void SceneL()
    {
        SceneManager.LoadScene("Stage2");
    } 
}


//    public bool GRABflg()
//    {
//        return grabflg;
//    }
//}






//public bool Insekiswitch()
//{
//    return Iswitch;
//}
