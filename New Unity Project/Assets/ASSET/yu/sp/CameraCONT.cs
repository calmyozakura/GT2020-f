using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCONT : MonoBehaviour {

    [SerializeField] private GameObject Yougantmp;
   
  //  public Transform target;//キャラの座標の入れ物
    public Vector3 offset;//キャラからの距離
                          // Use this for initialization

    //PlayerMo script; //UnityChanScriptが入る変数

    //Vector3 tmp;
    public bool Youganflg;
    Vector3 tmp;
    YOUGANMOVE script;

    void Start()
    {
        script = Yougantmp.GetComponent<YOUGANMOVE>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        tmp = Yougantmp.transform.position;
        Yougantmp.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(script.moveflg == true)
        {
            transform.Translate(offset.x, 0, 0);
        }


        //キャラの座標+オフセットの位置に移動する
        //transform.position = target.position + offset;

        //transform.Translate(offset.x, 0, 0);
    }
}
