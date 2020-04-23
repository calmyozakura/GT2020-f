using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouganATK : MonoBehaviour {

    float vector = 0.1f;
    private Vector3 height;
    bool HunkaR = false;
    bool stopflg = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (stopflg == false) Founka();

        
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "In")
        {
            stopflg = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        stopflg = false;
    }


    void Founka()
    {

        //オブジェクト拡大
        height = this.GetComponent<Transform>().position;
        if (height.y > 10)
        {
            HunkaR = true;
        }
        else if (height.y < -4) HunkaR = false;
        if (HunkaR == false)
        {
            this.transform.localScale = new Vector3(3, vector, 1);
            vector -= 0.20f;

            //等速アニメーション
            this.transform.position += new Vector3(0, 0.10f, 0);
        }
        else
        {
            this.transform.localScale = new Vector3(3, vector, 1);
            vector += 0.20f;

            //等速アニメーション
            this.transform.position -= new Vector3(0, 0.10f, 0);
        }

        //加速アニメーション
        //this.transform.position += new Vector3(vector, 0, 0);
        // this.transform.localScale = new Vector3(4, 1, 1);
    }

}
