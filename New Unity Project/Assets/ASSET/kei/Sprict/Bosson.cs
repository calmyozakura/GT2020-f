﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosson : MonoBehaviour {

    public int BossFlg = 1;
    private float Timer ;

    public GameObject beam;
    public GameObject ATK;
    public GameObject zimen;
    public GameObject giru;
    SingleDemo singledemo;

    // Use this for initialization
    void Start () {

        singledemo = GetComponent<SingleDemo>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (singledemo.ATKFlg == true) ATK.gameObject.SetActive(true);
        else ATK.gameObject.SetActive(false);
        switch (BossFlg)
        {
            case 1:
                singledemo.IdleActivate();
                if (++Timer / 6 == 66)
                {
                    BossFlg = 2;
                    Timer = 0;
                }
                break;
            case 2:
                singledemo.Activate();
                break;
            case 3:
                if (++Timer / 6 == 66)
                {
                    BossFlg = 4;
                    Timer = 0;
                }
                break;
            case 4:

                singledemo.Walk();

                if (++Timer / 6 == 6)
                {
                    beam.gameObject.SetActive(true);
                    BossFlg = 8;
                    Timer = 0;
                }
                break;

            case 5:
                if (++Timer / 6 == 18)
                {
                    singledemo.Atk01();
                   
                    BossFlg = 6;
                    Timer = 0;
                }
                break;
            case 6:

                if (++Timer / 6 == 18) { 
                    BossFlg = 7;
                    Timer = 0;
                }
                break;
            case 7:
                singledemo.Atk02();
                if (++Timer / 6 == 18)
                {
                    BossFlg = 4;
                    Timer = 0;
                }
                break;
            case 8:
                if (++Timer / 6 == 18)
                {
                    singledemo.Atk01();
                    Timer = 0;
                    
                    BossFlg = 9;
                }
                break;
            case 9:
                if(++Timer / 6 == 12)
                {
                    zimen.gameObject.SetActive(true);
                    Timer = 0;
                    BossFlg = 4;
                }
                break;
            case 10:
                if (++Timer / 6 == 12)
                {
                    singledemo.Run();
                    Timer = 0;
                    //BossFlg = 4;
                }
                break;

        }

        Debug.Log(BossFlg);

    }
}
