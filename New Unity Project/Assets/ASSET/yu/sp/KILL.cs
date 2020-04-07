using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KILL : MonoBehaviour {

    [SerializeField] private GameObject hp;
    life script; //UnityChanScriptが入る変数

    int HP;

    public Text oveText;
  
    void Start()
    {
        script = hp.GetComponent<life>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する

        HP = script.hp;
      
        oveText.enabled = false;
    }

    void Update()
    {
        if (HP == 0)
        {
            Debug.Log(HP);
            oveText.enabled = true;
            Destroy(gameObject);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{

    //  if (other.gameObject.tag == "Player")
    //    {
    //        oveText.enabled = true;
    //        Destroy(other.gameObject);
    //    }
    //}
}
