using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinoout : MonoBehaviour {

    public Animator Dino_Anim;

    public float vector;
    public float vector2;
    private bool migi = false;
    private bool Jp = false;
    private float waitTimer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        
        this.transform.position += new Vector3(+vector, 0, 0);
        Dino_Anim.SetBool("Run", true);     //走るモーション
    }
    //void FixedUpdate()
    //{




    //}
}
