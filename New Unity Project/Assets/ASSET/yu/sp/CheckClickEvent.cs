using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CheckClickEvent : MonoBehaviour {

    //　主人公キャラクターのダメージ処理スクリプト
    [SerializeField]
    private life life;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Yougan")
        {

            Debug.Log("ダメージ");
            life.Damage(1);
        }
    }
}

