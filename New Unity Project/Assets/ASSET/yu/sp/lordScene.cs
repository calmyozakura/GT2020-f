using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lordScene : MonoBehaviour {

    string loadScene;

    // Use this for initialization
    void Start () {
        // 現在のScene名を取得する
        loadScene = SceneManager.GetActiveScene().name;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(loadScene);
        }
    }
}
