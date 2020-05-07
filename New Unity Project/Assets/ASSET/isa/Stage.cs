using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour {

    Scene[] scene;

    public static int Stagecount = 0;

    Text txt;

	// Use this for initialization
	void Start () {

        Stagecount++;
        this.txt = this.GetComponent<Text>();

        Invoke("LoadScene", 3.5f);
    }
	
	// Update is called once per frame
	void Update () {


        this.txt.text = "Stage " + Stagecount.ToString();


        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Stagecount++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Stagecount--;
        }


    }

    // シーンのリロード（UIボタンクリックで呼び出す処理）
    public void LoadScene()
    {
        
        // シーンをロードする
        // 引数でシーン名の指定：変数 sceneに格納されたシーン名 scene.name
        SceneManager.LoadScene(scene[Stagecount].name);
    }
}
