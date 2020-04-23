using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal２ : MonoBehaviour {

    public Text goalText;
    [SerializeField] private float _nextSceneRate;
    private float nextSceneTime;

    //public bool goalOn;

    // Use this for initialization
    void Start()
    {
        goalText.enabled = false;
        //goalOn = false;
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

        //if(nextSceneTime > 0)
        //{
        //    nextSceneTime -= Time.deltaTime;
        //}
        //else
        //{
        //    // 現在のシーンを取得して変数 scene に格納
        //   // Scene scene = _nextStageScene;
        //    // シーンをロードする
        //    // 引数でシーン名の指定：変数 sceneに格納されたシーン名 scene.name
        //    SceneManager.LoadScene("stage2");
        //}


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && nextSceneTime > 0)
        {
            //rB.AddForce(-rbVelo.x * 0.8f, 0, -rbVelo.z * 0.8f, ForceMode.Impulse);
            goalText.enabled = true;
            nextSceneTime = _nextSceneRate;
            //goalOn = true;

            nextSceneTime -= Time.deltaTime;


        }
        else
        {
            SceneManager.LoadScene("Stage3");
        }
    }
    //public void LoadScene()
    //{
    //    // 現在のシーンを取得して変数 scene に格納
    //    Scene scene = SceneManager.GetActiveScene();
    //    // シーンをロードする
    //    // 引数でシーン名の指定：変数 sceneに格納されたシーン名 scene.name
    //    SceneManager.LoadScene(scene.name);
    //}
}
