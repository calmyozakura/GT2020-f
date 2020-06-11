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

    public Text oveText;
    public GameObject title;
    public GameObject rty;


    void Start()
    {
        title.SetActive(false);
        rty.SetActive(false);
        oveText.enabled = false;
        sceneName = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
 
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
                
                Destroy(gameObject);
                //SceneManager.LoadScene("Over");
            }
        }
        if (other.gameObject.tag == "item")
        {
            HP = life.recovery(HP, 1);

            Destroy(other.gameObject);
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Yougan2")
        {
            Destroy(gameObject);
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

            }
        }
    }
    void OnParticleTrigger(GameObject other)
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

            }
        }
    }
}

