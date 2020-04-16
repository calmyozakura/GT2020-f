using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CheckClickEvent : MonoBehaviour {

    [SerializeField]
    private life life;
    [SerializeField] private int HP;

    life script; //UnityChanScriptが入る変数

    public Text oveText;

    void Start()
    {
        oveText.enabled = false;
    }

        void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Yougan")
        {

            Debug.Log("ダメージ");
            HP = life.Damage(HP,1);
            if (HP <= 0)
            {
                Debug.Log(HP);
                oveText.enabled = true;
                Destroy(gameObject);
            }
        }
    }
}

