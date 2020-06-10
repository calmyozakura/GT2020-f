using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStop : MonoBehaviour {
    public Animator Boss;
    public int StopCount;
    // Use this for initialization
    void Start () {
        StopCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Attack")
            Boss.SetFloat("Stop", 1.0f);//一時停止

    }
}
