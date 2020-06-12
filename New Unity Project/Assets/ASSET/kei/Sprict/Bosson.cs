using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosson : MonoBehaviour {

    public int BossFlg = 1;
    private float Timer ;

    public GameObject beam;
    public GameObject ATK;
    public GameObject zimen;
    public GameObject giru;
    public GameObject cros;
    public GameObject cros2;
    public GameObject BossMagma;
    public GameObject Steam;
    SingleDemo singledemo;
    Bossanime BOSSanime;
    public Animator Boss;
    public int StopCount;

    public int NewDrug;
    public float Move;
    public GameObject LastATK;
    

    public bool MizuFlg;

    // Use this for initialization
    void Start () {

        singledemo = GetComponent<SingleDemo>();
        StopCount = 0;
        BOSSanime = GetComponent<Bossanime>();
        MizuFlg = false;
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")//水に落ちると
        {

            MizuFlg = true;


        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (MizuFlg == false)
        { 
            if (singledemo.ATKFlg == true) ATK.gameObject.SetActive(true);
            else ATK.gameObject.SetActive(false);
            switch (BossFlg)
            {
                case 1:

                    singledemo.IdleActivate();
                    if (++Timer / 6 == 22)
                    {
                        BossFlg = 2;
                        Timer = 0;
                    }
                    break;
                case 2:
                    singledemo.Activate();
                    BossMagma.gameObject.SetActive(true);
                    break;
                case 3:
                    if (++Timer / 6 == 66)
                    {
                        BossFlg = 12;
                        //BossFlg = 11;
                        Timer = 0;
                    }
                    break;
                case 4:

                    singledemo.Walk();

                    if (++Timer / 6 == 76)
                    {

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
                        Boss.SetFloat("Stop", 1.0f);//一時停止 0が停止 1が再開
                        BossFlg = 12;
                    }
                    break;
                case 9:
                    if (++Timer / 6 == 12)
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
                case 11:
                    singledemo.Run();
                    BOSSanime.moveflg = false;
                    Boss.SetFloat("Stop", 0.0f);//一時停止 0が停止 1が再開
                    if (++Timer / 6 >= 30)
                    {
                        cros.gameObject.SetActive(true);
                        if (Timer / 6 == 36)
                        {
                            cros2.gameObject.SetActive(true);
                            Timer = 0;
                            BossFlg = 4;
                        }
                    }
                    break;

                case 12:
                    {
                        BOSSanime.moveflg = false;
                        zimen.gameObject.SetActive(true);
                        singledemo.Run();
                        Boss.SetFloat("Stop", 0.0f);//一時停止 0が停止 1が再開
                        if (++Timer / 6 == 48)
                        {
                            zimen.gameObject.SetActive(false);
                            BossFlg = 4;
                            Timer = 0;
                        }
                    }

                    break;
            }
            //if (Input.GetKey(KeyCode.DownArrow)){
            //    // BossFlg = 11;
            //    Boss.SetFloat("Stop", 0.0f);//一時停止 0が停止 1が再開
            //}
            Debug.Log(BossFlg);
        }
        else
        {
            singledemo.Run();
            Boss.SetFloat("Stop", 0.5f);//一時停止 0が停止 1が再開
            BossMagma.gameObject.SetActive(false);
            Steam.gameObject.SetActive(true);
            this.GetComponent<Rigidbody>().drag = NewDrug;

            
          
                LastATK.gameObject.SetActive(true);
            
            //this.GetComponent<Transform>().position
            //Destroy(this.gameObject);//デストロイ

        }
    }
}
