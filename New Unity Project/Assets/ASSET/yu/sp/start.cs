using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart()
    {
        Debug.Log("くぁｗせｄｒｆｔｇｙふじこｌｐ");
        SceneManager.LoadScene("Stage1");
    }
}
