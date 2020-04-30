using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera5 : MonoBehaviour {

    [SerializeField] private GameObject Playertmp;

    //  public Transform target;//キャラの座標の入れ物
    public Vector3 offset;//キャラからの距離
                          // Use this for initialization

    PlayerMM script; //UnityChanScriptが入る変数

    //Vector3 tmp;
    public bool Youganflg;
    Vector3 tmp;




    void Start () {
        script = Playertmp.GetComponent<PlayerMM>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }
	
	// Update is called once per frame
	void Update () {

    }
}
