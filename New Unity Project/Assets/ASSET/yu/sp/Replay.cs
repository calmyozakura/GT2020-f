using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    
    //シーン名を指定する
    Scene scene = SceneManager.GetSceneByName("Stage2");

    string sceneName;
    public bool die = false;

    // Use this for initialization
    void Start () {
        //シーンを非同期で追加する
        
        sceneName = SceneManager.GetActiveScene().name;
    }
	
    public void RetryButton()
    {

        //指定したシーン名をアクティブにする
        // SceneManager.SetActiveScene(scene);

        //if (die == true) {
        Debug.Log("hsansnjxnjankjxknxa");
        SceneManager.LoadScene("Stage2");
         //   die = false;
       // }
    }
}
