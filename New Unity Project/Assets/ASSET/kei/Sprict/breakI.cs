using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakI : MonoBehaviour {
    public GameObject iwa;
    public GameObject part1;
    private Vector3 Iwa_posi;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Iwa_posi = this.transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "K")
        {
            Destroy(gameObject);

        }
        
        if (other.gameObject.tag == "Yougan")
        {
            part1.gameObject.SetActive(false);
            part1.transform.position = Iwa_posi;
            part1.gameObject.SetActive(true);//パーティクルをアクティブに
            Destroy(this.gameObject);//デストロイ
        }
    }

}
