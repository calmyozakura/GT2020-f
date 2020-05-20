using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YOUGANMOVE : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    public bool moveflg = true;   //true：動く false：動かない
    [SerializeField] private float movelate = 4f;    //動かなくなったら、次に動くまでの秒数
    private float movecount;
    private PLAYERMO PLAYERMO;
    public float vector = 0.05f;

    //public AudioSource source;

    PLAYERMO script; //UnityChanScriptが入る変数

    void Start()
    {

    }

    // Update is called once per frame


    void FixedUpdate()
    {
        //if (script.MagumaSPD == true)
        //{
        //    vector += 0.02f;
        //}
        if (movecount > 0)
        {
            movecount -= Time.deltaTime;
        }

        if (moveflg == false && movecount < 0)
        {
            moveflg = true;
        }

        if (!moveflg) return;

        //オブジェクト拡大
        //this.transform.localScale = new Vector3(vector, 3, 1);

        //等速アニメーション
        this.transform.position += new Vector3(vector, 0, 0);

        //加速アニメーション
        //this.transform.position += new Vector3(vector, 0, 0);
        // this.transform.localScale = new Vector3(4, 1, 1);
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
    //void OnParticleCollision(GameObject other)
    //{
    //    if (other.gameObject.tag == "In")
    //    {
    //        Destroy(other.gameObject, movelate);   //4秒後に隕石が消える
    //        //}
    //        Debug.Log("当たった!");
    //        moveflg = false;
    //        movecount += movelate;

    //    }
    //}
}