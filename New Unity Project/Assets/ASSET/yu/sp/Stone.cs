using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    //変数を作る
    Rigidbody rb;
    
    [SerializeField] private GameObject Playertmp;
    [SerializeField] private float movelate = 4f;    //動かなくなったら、次に動くまでの秒数

    //public bool grabflg;    //falseだったら動く　//trueだったら止める
    public bool Grabflg;
    private float waitTimer = 0;
    Glag script; //UnityChanScriptが入る変数

    float axis_R_UD, axis_R_LR;//右スティック
    
    Vector3 tmp;

    float gx;   //このゲームオブジェクトの調整用変数
    float gy;
    float gz;

    //ゲーム起動時に呼び出される
    void Start()
    {
        //grabflg = false;

        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();

        script = Playertmp.GetComponent<Glag>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        tmp = Playertmp.transform.position;
        Playertmp.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);

        gx = 0;
        gy = 0;
        gz = 0;
    }

    void Update()
    {



        Debug.Log(Grabflg);
        if (Grabflg == true)
        {
            tmp = Playertmp.transform.position;
            axis_R_LR = Input.GetAxis("DS4_R_JoystickLR");
            axis_R_UD = Input.GetAxis("DS4_R_JoystickUD");

            //this.transform.position = new Vector3(tmp.x-3, tmp.y+3, tmp.z);
            this.transform.position = new Vector3(tmp.x + gx, tmp.y + gy, tmp.z + gz);
            { 
            if (Input.GetKey(KeyCode.A) && Grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = -5f;
                gy = 3f;
                gz = 0;

            }

            if (Input.GetKey(KeyCode.S) && Grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x , tmp.y + 4, tmp.z);
                gx = 0;
                gy = 8f;
                gz = 0;

            }

            if (Input.GetKey(KeyCode.D) && Grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = 7f;
                gy = 3f;
                gz = 0;

            }

            if (Input.GetKey(KeyCode.Space)  && Grabflg == true &&  ++waitTimer / 6 == 3)
            {

                //重力を戻す
                rb.isKinematic = false;
                Grabflg = false;
                script.grabflg = false;
                waitTimer = 0;
            }
            }

            {
                if (axis_R_LR < 0 && Grabflg == true)
                {

                    //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                    gx = -5f;
                    gy = 3f;
                    gz = 0;

                }

                if (axis_R_UD < 0 && Grabflg == true)
                {

                    //this.transform.position = new Vector3(tmp.x , tmp.y + 4, tmp.z);
                    gx = 0;
                    gy = 8f;
                    gz = 0;

                }

                if (axis_R_LR > 0 && Grabflg == true)
                {

                    //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                    gx = 7f;
                    gy = 3f;
                    gz = 0;

                }

                if (Input.GetButton("DS4_Triangle") && Grabflg == true && ++waitTimer / 6 == 3)
                {

                    //重力を戻す
                    rb.isKinematic = false;
                    Grabflg = false;
                    script.grabflg = false;
                    waitTimer = 0;
                }
            }
        }
    }

    void OnCollisionStay(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (script.grabflg == false)
            {
                if (Input.GetKey(KeyCode.Space)|| Input.GetButton("DS4_Triangle") && Grabflg == false)
                {
                   
                    
                        //重力を止める
                        rb.isKinematic = true;
                        script.grabflg = true;
                        Grabflg = true;
                        this.transform.Translate(0.0f, 1.0f, 0.0f);
                        gx = -5f;
                        gy = 3f;
                        gz = 0;
                    
                }
            }
        }

    }
    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Yougan")
        {
            Destroy(gameObject, movelate);   //4秒後に隕石が消える
            //}
            Debug.Log("当たった!");
            //moveflg = false;
            //movecount += movelate;

        }
    }
}