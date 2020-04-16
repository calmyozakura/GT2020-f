﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera4 : MonoBehaviour {

    [SerializeField] private GameObject Yougantmp;
    [SerializeField] private GameObject Playertmp;

    //  public Transform target;//キャラの座標の入れ物
    public Vector3 offset;//キャラからの距離

    public bool Youganflg, Playerflg;
    Vector3 tmp, tmp1;              //tmp 溶岩；tmp1　プレイヤー
    YOUGANMOVE script;
    PLAYERMO script1;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;

        //プレイヤー座標
        script1 = Playertmp.GetComponent<PLAYERMO>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        tmp1 = Playertmp.transform.position;
        Playertmp.transform.position = new Vector3(tmp1.x, tmp1.y, tmp1.z);

        //溶岩座標
        script = Yougantmp.GetComponent<YOUGANMOVE>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        tmp = Yougantmp.transform.position;
        Yougantmp.transform.position = new Vector3(tmp.x, tmp.y, tmp.z);
    }

    // Update is called once per frame
    void Update()
    {
        //if (script.moveflg == true)
        //{
        //    transform.Translate(offset.x, 0, 0);
        //}
        offset.x = ((Playertmp.transform.position.x - Yougantmp.transform.position.x - Yougantmp.transform.position.x / 2) / 2);

        //transform.Translate(offset.x, 0, 0);

        transform.position = new Vector3(Yougantmp.transform.position.x + (Yougantmp.transform.position.x/2)+
                 offset.x, startPosition.y, startPosition.z);
    }
}
