using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    string sceneName;

    // Use this for initialization
    void Start () {
        sceneName = SceneManager.GetActiveScene().name;
    }
	
    public void RetryButton()
    {
        
        SceneManager.LoadScene(sceneName);
       
    }
}
