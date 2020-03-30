using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Attack1Cont : MonoBehaviour
{
   

    public Animator Attack1;
    public int Attak1count = 0;
    public bool Stopflg = false;
    public GameObject M_Attack1Pivot;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Stopflg)
        {
            Attak1count += 1;
            if (Attak1count >= 60)
            {
                Attak1count = 0;
                Stopflg = false;
                M_Attack1Pivot.gameObject.SetActive(false);
               
            }
            if (Attak1count >= 200)
            {
                M_Attack1Pivot.gameObject.SetActive(true);
                Attak1count = 0;
                Stopflg = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "In")//岩に当たったら
        {
           Attack1.SetFloat("Attack1Para", 0.0f);//一時停止
           // Destroy(M_Attack1Pivot.gameObject, 1.0f);//デストロイ
            Stopflg = true;
        }
        //moveflg = true;  
    }
}
