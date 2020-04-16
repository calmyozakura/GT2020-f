using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSEKI : MonoBehaviour {

    GameObject player; //Unityちゃんそのものが入る変数

    PlayerMo script; //UnityChanScriptが入る変数

    void Start()
    {
        player = GameObject.Find("Player"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = player.GetComponent<PlayerMo>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }
    void Update()
    {
        if (script.Iswitch == true)
        {
            Invoke("Fall", 0);
        }
    }

    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
