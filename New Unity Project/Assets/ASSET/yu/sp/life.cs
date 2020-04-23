using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {

    //　HP
    [SerializeField]
    public int hp;
    [SerializeField]
    private LifeGauge lifeGauge;
    
    [SerializeField]
    //private int damage;

    void Start()
    {
        hp = 3;
        //　体力ゲージに反映
        lifeGauge.SetLifeGauge(hp);
   
    }

    void Update()
    {
        Debug.Log(hp);
    }
    //　ダメージ処理メソッド（全削除＆HP分作成）
    public int Damage(int hp,int damage)
    {
        hp -= damage;
        //　0より下の数値にならないようにする
        hp = Mathf.Max(0, hp);

        if (hp >= 0)
        {
            lifeGauge.SetLifeGauge(hp);
        }
        return hp;
    }
    public int recovery(int hp, int damage)
    {
        hp += damage;

        hp = Mathf.Max(0, hp);

        if(hp >= 0)
        {
            lifeGauge.SetLifeGauge(hp);
        }
        return hp;
    }
    //　ダメージ処理メソッド（ダメージ数分だけアイコンを削除）
    public int Damage2(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            //　ダメージ調整
            damage = Mathf.Abs(hp + damage);
            hp = 0;
        }
        if (damage > 0)
        {
            lifeGauge.SetLifeGauge2(damage);
        }
        return hp;
    }
    
}
