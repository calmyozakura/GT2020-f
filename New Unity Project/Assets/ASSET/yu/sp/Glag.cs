using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glag : MonoBehaviour
{

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



    }

    void Update()
    {


    }

}
