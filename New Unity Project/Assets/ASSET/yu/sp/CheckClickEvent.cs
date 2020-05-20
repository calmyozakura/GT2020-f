using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckClickEvent : MonoBehaviour {

    string sceneName;
    [SerializeField]
    private life life;
    [SerializeField] private int HP;

    life script; //UnityChanScriptが入る変数

    //public Text oveText;

    void Start()
    {
        //oveText.enabled = false;
        sceneName = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        //if (HP <= 0)
        //{
        //    SceneManager.LoadScene("Over");
        //}    
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Yougan")
        {

            Debug.Log("ダメージ");
            HP = life.Damage(HP, 1);
            if (HP <= 0)
            {
                Debug.Log(HP);
                //oveText.enabled = true;
                Destroy(gameObject);
                SceneManager.LoadScene("Over");
            }
        }
        if (other.gameObject.tag == "item")
        {
            HP = life.recovery(HP, 1);

            Destroy(other.gameObject);
        }
        
    }
    void OnParticleCollision(GameObject other)
    {
        //Debug.Log("衝突");
        if (other.gameObject.tag == "Yougan")
        {

            Debug.Log("ダメージ");
            HP = life.Damage(HP, 1);
            if (HP <= 0)
            {
                Debug.Log(HP);
                //oveText.enabled = true;
                Destroy(gameObject);
                SceneManager.LoadScene("Over");
            }
        }
    }  
}

