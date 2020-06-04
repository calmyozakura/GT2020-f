using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosson : MonoBehaviour {

    public int BossFlg = 1;
    private float Timer ;
    SingleDemo singledemo;

    // Use this for initialization
    void Start () {

        singledemo = GetComponent<SingleDemo>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        switch (BossFlg) {
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
      }

   

    }
}
