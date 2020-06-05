using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossATK : MonoBehaviour {

    SingleDemo singledemo;
    
	// Use this for initialization
	void Start () {
        singledemo = GetComponent<SingleDemo>();
       // GetComponent<BoxCollider>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        //if(singledemo.ATKFlg == true){

        //    GetComponent<BoxCollider>().enabled = true ;

        //}else GetComponent<BoxCollider>().enabled = false;
    }
}
