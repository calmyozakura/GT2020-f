using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCount
{
    private float Interval = 0.5f; //計測頻度
    private float Accum    = 0.0f; //蓄積値
    private float Rest     = 0.0f; //残り時間
    private float fps      = 0.0f; //計算結果

    private int   Frame    = 0;    //フレーム値


    /*----------------------------------------------------*/
    public FPSCount()
    {

    }

    public void CountUpDate()
    {
        Rest  -= Time.deltaTime;
        Accum += Time.timeScale / Time.deltaTime;
        Frame ++;

        if(Rest <= 0.0f)
        {
            fps = Accum / Frame;
            Rest = Interval;
            Accum = 0.0f;
            Frame = 0;
        }
    }

    public float getfps()
    {
        return fps;
    }

    
}