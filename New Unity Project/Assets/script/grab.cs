using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour {

    //変数を作る
    Rigidbody rb;

    [SerializeField] private GameObject Playertmp;

    public bool grabflg = false;    //falseだったら停止　//trueだったら動く

    PlayerMo script; //UnityChanScriptが入る変数

    Vector3 tmp;

    float x;
    float y;
    float z;

    //ゲーム起動時に呼び出される
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
        
        script = Playertmp.GetComponent<PlayerMo>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        tmp = Playertmp.transform.position;
        Playertmp.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);

        x = tmp.x;
        y = tmp.y;
        z = tmp.z;
    }

    void Update()
    {

        Debug.Log(script.playerU);
        if(grabflg == true)
        {
            tmp = Playertmp.transform.position;
            this.transform.position = new Vector3(tmp.x-3, tmp.y+3, tmp.z);

            if (script.playerU == 1)//上
            {
                //this.transform.position = new Vector3(0, 0.1f, 0);
                script.playerU = 0;
            }
            if (script.playerU == 2)//左
            {
                //this.transform.position += new Vector3(-0.1f, 0, 0);
                script.playerU = 0;
             
            }
            else if (script.playerU == 3)//右
            {
                script.playerU = 0;
                //this.transform.position += new Vector3(0.1f, 0, 0);
            }
            if (Input.GetKey(KeyCode.W) && grabflg == true)
            {
               
                //重力を停止させる
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
            if (Input.GetKey(KeyCode.W) && grabflg == true)
            {
               

               //重力を停止させる
               rb.isKinematic = false;
                
                grabflg = false;
            }

            // 上に移動
            else if (Input.GetKey(KeyCode.Space) && grabflg == false)
            {
               
             //重力を動かす
             rb.isKinematic = true;
                
                grabflg = true;
                this.transform.Translate(0.0f, 1.0f, 0.0f);
            }
           
        }
    }
}
