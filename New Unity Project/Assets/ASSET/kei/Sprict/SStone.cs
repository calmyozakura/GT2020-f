﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SStone : MonoBehaviour
{
    //変数を作る
    Rigidbody rb;
    [SerializeField] private GameObject Playertmp;
    //public bool grabflg;    //falseだったら動く　//trueだったら止める
    public bool Grabflg;
    private float waitTimer = 0;
    Glag script; //UnityChanScriptが入る変数
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
            //this.transform.position = new Vector3(tmp.x-3, tmp.y+3, tmp.z);
            this.transform.position = new Vector3(tmp.x + gx, tmp.y + gy, tmp.z + gz);
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
                gy = 4f;
                gz = 0;
            }
            if (Input.GetKey(KeyCode.D) && Grabflg == true)
            {
                //this.transform.position = new Vector3(tmp.x +4  , tmp.y + 3, tmp.z);
                gx = 4f;
                gy = 3f;
                gz = 0;
            }
            if (Input.GetKey(KeyCode.Space) && Grabflg == true && ++waitTimer / 6 == 3)
            {
                //重力を戻す
                rb.isKinematic = false;
                Grabflg = false;
                script.grabflg = false;
                waitTimer = 0;
            }
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (script.grabflg == false)
            {
                if (Input.GetKey(KeyCode.Space) && Grabflg == false)
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
}