using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ST : MonoBehaviour {


    float Axis_UD, Axis_LR, Axis2_UD, Axis2_LR; // Axis = 十字　Axis2 = アナログパッド


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("DS4_Circle")) GameStart();

    }

    public void GameStart()
    {
        SceneManager.LoadScene("Stage1");
    }
}
