using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glag : MonoBehaviour {

    //変数を作る
    Rigidbody rb;

    [SerializeField] private GameObject Playertmp;

    public bool grabflg;    //falseだったら動く　//trueだったら止める

    PlayerMo script; //UnityChanScriptが入る変数

    Vector3 tmp;

    float gx;   //このゲームオブジェクトの調整用変数
    float gy;
    float gz;

    //ゲーム起動時に呼び出される
    void Start()
    {
        grabflg = false;

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

        Debug.Log(grabflg);
        if (grabflg == true)
        {
            tmp = Playertmp.transform.position;
            //this.transform.position = new Vector3(tmp.x-3, tmp.y+3, tmp.z);
            this.transform.position = new Vector3(tmp.x + gx, tmp.y + gy, tmp.z + gz);

            if (Input.GetKey(KeyCode.A) && grabflg == true)
            {

                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = -5f;
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

        if (other.gameObject.tag == "In")
        {
            if (grabflg == false) { 
                // 上に移動
                if (Input.GetKey(KeyCode.Space) && grabflg == false)
                {

                    //重力を動かす
                    rb.isKinematic = true;

                    grabflg = true;
                    this.transform.Translate(0.0f, 1.0f, 0.0f);
                    gx = -5f;
                    gy = 3f;
                    gz = 0;
                }
            }
        }
    }
}
