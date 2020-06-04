using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosson : MonoBehaviour {

    public int BossFlg = 1;
    private float Timer ;

    public GameObject beam;
    SingleDemo singledemo;

    // Use this for initialization
    void Start () {

        singledemo = GetComponent<SingleDemo>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

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
                    BossFlg = 5;
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
        }

   

    }
}
