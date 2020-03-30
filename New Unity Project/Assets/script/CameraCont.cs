using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCont : MonoBehaviour {
    public Transform target;//キャラの座標の入れ物
    public Vector3 offset;//キャラからの距離
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //キャラの座標+オフセットの位置に移動する
        //transform.position = target.position + offset;

        transform.Translate(offset.x, 0, 0);
    }
}
