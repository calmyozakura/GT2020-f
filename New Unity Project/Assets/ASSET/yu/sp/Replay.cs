using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    string loadScene;

    // Use this for initialization
    void Start () {
        // 現在のScene名を取得する
        loadScene = SceneManager.GetActiveScene().name;
    }
	
    public void RetryButton()
    {      
        Debug.Log("hsansnjxnjankjxknxa");
        //SceneManager.LoadScene("Stage2");
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene);
        //SceneManager.GetActiveScene();
    }
}
