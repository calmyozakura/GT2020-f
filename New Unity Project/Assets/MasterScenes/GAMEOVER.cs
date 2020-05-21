using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVER : MonoBehaviour {

    public GameObject Dino;
    private float step_time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Dino == null)
        {
            step_time += Time.deltaTime;
           // Debug.Log(step_time);
        }
        if (step_time >= 6.0f)
        {
            SceneManager.LoadScene("Over");
        }
    }
}
