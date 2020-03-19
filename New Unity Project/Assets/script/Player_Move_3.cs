using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_3 : MonoBehaviour {

    //Unityで設定する
    public float flap = 1000f;  //ジャンプ力
    public float scroll = 5f;   //Xの移動スピード

    //変数
    float direction = 0f;

    //Bool型
    bool jump = false;

    //プライベート
    private Rigidbody rb = null;

    private Transform tf = null;

    void Start()
    {
        //コンポーネントのインスタンスを捕まえる
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        //transform.localRotation = Quaternion.Euler(0f, 0f, 0f);//画像の傾き
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(groundflg);
        Move();
    }


    void Move()
    {
        //左右キー入力されたら行動する
        float horizontalKey = Input.GetAxis("Horizontal");


        //キーボード操作
        //if (Input.GetKey(KeyCode.RightArrow))
        if (horizontalKey > 0)
        {
            direction = 1f;
        }
        //else if (Input.GetKey(KeyCode.LeftArrow))
         else if (horizontalKey < 0)
        {
            direction = -1f;
        }
        else
        {
            direction = 0f;
        }


        //キャラのy軸のdirection方向にscrollの力をかける
        rb.velocity = new Vector2(scroll * direction, rb.velocity.y);
        //ジャンプ判定
        if (Input.GetKeyDown("space") && !jump)
        {
            rb.AddForce(Vector3.up * flap);
            jump = true;
        }
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{ 
    //}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))//地面のタグ(地面に触れたときにもう一度ジャンプできるようになる)
        {
            jump = false;
        }
    }
}
