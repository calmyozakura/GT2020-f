using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCONT : MonoBehaviour {

    [SerializeField] private GameObject Yougantmp;

    private bool CameraStop = false;

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
    void FixedUpdate()
    {
        //if(script.moveflg == true && CameraStop == false)
        if (script.moveflg == true && transform.position.x <= 637.7f)
            {
            transform.Translate(offset.x, offset.y,offset.z);


            //Transform myTransform = this.transform;


            //Vector3 worldAngle = myTransform.eulerAngles;
            ////worldAngle.x = 10.0f; // ワールド座標を基準に、x軸を軸にした回転を10度に変更
            //worldAngle.y = 10.0f; // ワールド座標を基準に、y軸を軸にした回転を10度に変更
            //worldAngle.z = 10.0f; // ワールド座標を基準に、z軸を軸にした回転を10度に変更
            //myTransform.Rotate(0, worldAngle.y, worldAngle.z);
        }


        //キャラの座標+オフセットの位置に移動する
        //transform.position = target.position + offset;

        //transform.Translate(offset.x, 0, 0);
    }
    public void moveflagfalse()
    {
        CameraStop = true;
        
    }

}
