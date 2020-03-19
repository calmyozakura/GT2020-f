using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotAngle = 1.0f;

    void FixedUpdate()
    {
        // transform���擾
        Transform myTransform = this.transform;

        Vector3 worldAngle = myTransform.eulerAngles;
       // float world_angle_x = worldAngle.x; // ���[���h���W����ɂ����Ax�������ɂ�����]�p�x

        if (transform.localEulerAngles.z < -45f) rotAngle = 0;
        // transform.Rotate(0f, 0f, rotAngle);

        if (worldAngle.z < 350f)
        {
            Debug.Log(worldAngle.z);
        }
        else  {
            worldAngle.z += -1.0f;
        }
        
        myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
    }
}
