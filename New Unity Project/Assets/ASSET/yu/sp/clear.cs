using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {

    public Text clearText;

    // Use this for initialization
    void Start () {
        clearText.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Clear")
        {
            clearText.enabled = true;
        }
        if (other.gameObject.tag == "title")
        {
            SceneManager.LoadScene("title");
        }
    }
}
