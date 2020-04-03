using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour {

    //変数を作る
    Rigidbody rb;

    [SerializeField] private GameObject Playertmp;

    public bool grabflg = false;    //falseだったら動く　//trueだったら止める

    PlayerMo script; //UnityChanScriptが入る変数

    Vector3 tmp;

    float gx;   //このゲームオブジェクトの調整用変数
    float gy;
    float gz;


    // Axis = 十字　Axis2 = アナログパッド
    float Axis_UD, Axis_LR, Axis2_UD, Axis2_LR; 

    //ゲーム起動時に呼び出される
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
        
        script = Playertmp.GetComponent<PlayerMo>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        tmp = Playertmp.transform.position;
        Playertmp.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);

        gx = 0;
        gy = 0;
        gz = 0;
    }

    void Update()
    {

        //十字&左アナログパッド、両方の軸を取得
        Axis_LR = Input.GetAxis("DS4_L_CrossLR");
        Axis_UD = Input.GetAxis("DS4_L_CrossUD");

        Axis2_LR = Input.GetAxis("DS4_L_JoystickLR");
        Axis2_UD = Input.GetAxis("DS4_L_JoystickUD");

        Debug.Log(script.playerU);
        if(grabflg == true)
        {



            tmp = Playertmp.transform.position;
            //this.transform.position = new Vector3(tmp.x-3, tmp.y+3, tmp.z);
            this.transform.position = new Vector3(tmp.x + gx, tmp.y + gy, tmp.z + gz);

            //コントローラー
            if ((Axis_LR > 0 || Axis2_LR > 0) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = -3f;
                gy = 3f;
                gz = 0;

            }

            if ((Axis_UD > 0 || Axis2_UD < 0) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x , tmp.y + 4, tmp.z);
                gx = 0;
                gy = 4f;
                gz = 0;

            }

            if ((Axis_LR < 0 || Axis2_LR < 0) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = 4f;
                gy = 3f;
                gz = 0;

            }
            
            if ((Axis_UD < 0 || Axis2_UD > 0) && grabflg == true)
            {

                //重力を戻す
                rb.isKinematic = false;

                grabflg = false;
            }

            //キーボード
            if (Input.GetKey(KeyCode.A) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = -3f;
                gy = 3f;
                gz = 0;

            }

            if (Input.GetKey(KeyCode.S) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x , tmp.y + 4, tmp.z);
                gx = 0;
                gy = 4f;
                gz = 0;

            }

            if (Input.GetKey(KeyCode.D) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = 4f;
                gy = 3f;
                gz = 0;

            }

            if (Input.GetKey(KeyCode.W) && grabflg == true)
            {

                //重力を戻す
                rb.isKinematic = false;

                grabflg = false;
            }
        }
    }

    private void OnCollisionStay(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {

            // 上に移動
            if ((Input.GetKey(KeyCode.Space) || Input.GetButton("DS4_Triangle") && grabflg == false))
            {
               
             //重力を動かす
             rb.isKinematic = true;
                
                grabflg = true;
                this.transform.Translate(0.0f, 1.0f, 0.0f);
                gx = -3f;
                gy = 3f;
                gz = 0;
            }
           
        }
    }
}
