using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfer : MonoBehaviour {

    [SerializeField] private float moveSpeed;

    float vector = 0.03f;

    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;

        pos.x += vector;    // x座標へ0.01加算

        myTransform.position = pos;  // 座標を設定

        
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           transform.parent = GameObject.Find("Player").transform;
            vector = 0.3f;
        }
        else vector = 0.03f;
    }
}
