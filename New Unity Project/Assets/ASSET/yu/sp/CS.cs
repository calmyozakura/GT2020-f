using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS : MonoBehaviour {

    public CameraShake shake;

    private void Update()
    {
        
            shake.Shake(0.5f, 0.5f);
        
    }
}
