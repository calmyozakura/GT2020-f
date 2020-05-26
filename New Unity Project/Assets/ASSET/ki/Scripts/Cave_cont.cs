using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave_cont : MonoBehaviour
{
    
    byte AlfaCount=255;
    public GameObject Cave;
    MeshRenderer CaveColor;
    public bool triger=false;
	// Use this for initialization
	void Start ()
    {
        CaveColor = Cave.GetComponent<MeshRenderer>();
        //CaveColor.material.color = 1.0f;
        //CaveColor.a = 0.01f;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")//プレイヤーが洞窟に入ると
        {
            if(CaveColor.material.color.a > 0.8f)                   //透明になってく
            {
                AlfaCount -= 1;
                triger = true;
                //CaveColor.a = AlfaCount;
                CaveColor.material.color -= new Color32(0,0,0,1);
               
            }
           
        }
    }
   
}
