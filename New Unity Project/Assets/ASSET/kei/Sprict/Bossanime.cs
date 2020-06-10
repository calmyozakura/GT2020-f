using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossanime : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    public bool moveflg = true;   //true：動く false：動かない
    [SerializeField] private float movelate = 4f;    //動かなくなったら、次に動くまでの秒数
    private float movecount;
    private PLAYERMO PLAYERMO;
    public float vector;

    public GameObject Circle;

    SingleDemo  singledemo;
    Bosson bosson;

        PLAYERMO script; //UnityChanScriptが入る変数

    void Start()
    {
        singledemo = GetComponent<SingleDemo>();
        bosson = GetComponent<Bosson>();
    }

    // Update is called once per frame


    void FixedUpdate()
    {
        if (bosson.BossFlg > 3 && bosson.BossFlg != 12 && bosson.BossFlg != 11)
        {
            Destroy(Circle.gameObject);

            //if (script.MagumaSPD == true)
            //{
            //    vector += 0.02f;
            //}
            if (movecount > 0)
            {
                movecount -= Time.deltaTime;
            }

            if (bosson.BossFlg > 3 ) moveflg = true;

            //オブジェクト拡大
            //this.transform.localScale = new Vector3(vector, 3, 1);

                //等速アニメーション
                this.transform.position += new Vector3(vector, 0, 0);


            //加速アニメーション
            //this.transform.position += new Vector3(vector, 0, 0);
            // this.transform.localScale = new Vector3(4, 1, 1);
        }
        else moveflg = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Speed")
        {
            vector += 0.01f;
        }


        if (other.gameObject.tag == "Sa")
        {
            vector = 0.07f;
        }
    }
}