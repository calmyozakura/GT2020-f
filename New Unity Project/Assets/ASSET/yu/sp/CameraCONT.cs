using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCONT : MonoBehaviour {

    //[SerializeField] private GameObject Playertmp;

    public Transform target;//キャラの座標の入れ物
    public Vector3 offset;//キャラからの距離
                          // Use this for initialization

    //PlayerMo script; //UnityChanScriptが入る変数

    //Vector3 tmp;

    void Start()
    {
        //script = Playertmp.GetComponent<PlayerMo>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        //tmp = Playertmp.transform.position;
        //Playertmp.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
    }

    // Update is called once per frame
    void Update()
    {

        //キャラの座標+オフセットの位置に移動する
        //transform.position = target.position + offset;

        transform.Translate(offset.x, 0, 0);
    }
}
