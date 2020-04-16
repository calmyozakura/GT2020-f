using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReload : MonoBehaviour {

    // シーンのリロード（UIボタンクリックで呼び出す処理）
    public void LoadScene()
    {
        // 現在のシーンを取得して変数 scene に格納
        Scene scene = SceneManager.GetActiveScene();
        // シーンをロードする
        // 引数でシーン名の指定：変数 sceneに格納されたシーン名 scene.name
        SceneManager.LoadScene(scene.name);
    }
}
