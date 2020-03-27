using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMo : MonoBehaviour {


    public float vector = 0.1f;
    public float vector2 = 0.1f;
    bool  Yoin = false;
   public bool Iswitch = false;
    public float playerU = 0;

	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))//上
        {
            this.transform.position += new Vector3(0, +vector2, 0);
            playerU = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//左
        {
            this.transform.position += new Vector3(-vector,0, 0);
            playerU = 2;
            //  this.transform.localScale = new Vector3(-1, 1, 1);
        }
        else  if (Input.GetKey(KeyCode.RightArrow))//右
        {
            playerU = 3;
            this.transform.position += new Vector3(+vector,0, 0);
           // this.transform.localScale = new Vector3(1, 1, 1);
        }
        

        if (Yoin == true)
        {
            YOIN();
        }
    }

    void OnCollisionStay(Collision collision)
        {
        if (collision.gameObject.tag == "Speed")
        {
            Debug.Log("a");
            // this.transform.position += new Vector3(100, 0, 0);
            vector = 0.5f;
        }
      
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Speed")
        {
            Debug.Log("b");
            Yoin = true;
        }
    }
   void  YOIN()
    {
            if (vector <= 0.2f)
            {
                Yoin = false;
            }
            else
        {
            Debug.Log(vector);
            vector -= 0.01f;
        }
    }

     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Line"))
        {
            Iswitch = true;
        }
    }

    public bool Insekiswitch()
    {
        return Iswitch;
    }
}
