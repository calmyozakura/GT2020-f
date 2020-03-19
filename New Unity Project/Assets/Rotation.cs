using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotAngle = 1.0f;

    void FixedUpdate()
    {
        // transformを取得
        Transform myTransform = this.transform;

        Vector3 worldAngle = myTransform.eulerAngles;
       // float world_angle_x = worldAngle.x; // ワールド座標を基準にした、x軸を軸にした回転角度

        if (transform.localEulerAngles.z < -45f) rotAngle = 0;
        // transform.Rotate(0f, 0f, rotAngle);

        if (worldAngle.z < 350f)
        {
            Debug.Log(worldAngle.z);
        }
        else  {
            worldAngle.z += -1.0f;
        }
        
        myTransform.eulerAngles = worldAngle; // 回転角度を設定
    }
}
