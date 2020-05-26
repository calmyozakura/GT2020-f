using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAMEOVER : MonoBehaviour {

    public GameObject Dino;
    private float step_time;

    public Text oveText;
    public GameObject title;
    public GameObject rty;

   
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
        if (step_time >= 4.0f)
        {
            rty.SetActive(true);
            title.SetActive(true);
            oveText.enabled = true;
            

          
        }
    }
}
