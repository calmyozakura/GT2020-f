using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour {

    float vector = 0.1f;


    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Speed"))
        {

            // transformを取得
            Transform myTransform = this.transform;

            // 座標を取得
            Vector3 pos = myTransform.position;

            pos.x += 0.3f;    // x座標へ0.01加算

            myTransform.position = pos;  // 座標を設定

            Debug.Log("a");
           // this.transform.position += new Vector3(0.5f, 0, 0);
            //vector += 0.01f;
        }
    }
    
}
