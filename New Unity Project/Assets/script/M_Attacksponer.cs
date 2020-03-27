using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Attacksponer : MonoBehaviour
{

    //障害物を入れておく
    [SerializeField] GameObject[] Attack;
    //次に出現するまでの時間
    [SerializeField] float appearNextTime;
    //最大数
    [SerializeField] int maxNumOfAttack;
    //今出現してる数
    private int numberOfAttack;
    //待ち時間計測
    private float elapsedTime;

    // Use this for initialization
    void Start()
    {
        numberOfAttack = 0;
        elapsedTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //最大数を超えていれば何もしない
        if (numberOfAttack >= maxNumOfAttack)
        {
            return;
        }
        //経過時間を足す
        elapsedTime += Time.deltaTime;

        //経過時間がたったら
        if (elapsedTime > appearNextTime)
        {
            elapsedTime = 0f;
            AppearEnemy();
        }
    }
    //敵出現メソッド
    void AppearEnemy()
    {
        //出現させる敵をランダムに選ぶ
        var randomValue = Random.Range(0, Attack.Length);
        //敵の向きをランダムに決定
        //var randomRotationY = Random.value * 360f;

        GameObject.Instantiate(Attack[randomValue], transform.position, Quaternion.Euler(0f, -5f, 0f));

        numberOfAttack++;
        elapsedTime = 0f;
    }
}