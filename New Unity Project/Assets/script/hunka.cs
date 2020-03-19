using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunka : MonoBehaviour
{


    [SerializeField] private float moveSpeed;

    GameObject HHunka; //Unityちゃんそのものが入る変数
    hunkaSW script; //UnityChanScriptが入る変数

    float vector = 0.1f;
    private Vector3 height;
    bool HunkaR = false;

    void Start()
    {
        HHunka = GameObject.Find("Hunka"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = HHunka.GetComponent<hunkaSW>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame



     void Update()
    {
        if (script.hunkaFlg == true)
        {
            Invoke("Founka", 3);
        }
    }





    void Founka()
    {
        //オブジェクト拡大
        height = this.GetComponent<Transform>().position;
        if (height.y > 5)
        {
            HunkaR = true;
        }
       else if(height.y < -4) HunkaR = false;
        if (HunkaR == false)
        {
            this.transform.localScale = new Vector3(3, vector, 1);
             vector -= 0.20f;

        //等速アニメーション
            this.transform.position += new Vector3(0, 0.10f, 0);
        }
        else 
        {
            this.transform.localScale = new Vector3(3, vector, 1);
            vector += 0.20f;

            //等速アニメーション
            this.transform.position -= new Vector3(0, 0.10f, 0);
        }

        //加速アニメーション
        //this.transform.position += new Vector3(vector, 0, 0);
        // this.transform.localScale = new Vector3(4, 1, 1);
    }
}

