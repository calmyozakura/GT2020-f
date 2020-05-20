using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Br : MonoBehaviour {

    //音用
    AudioSource source;
    public AudioClip clip;
	// Use this for initialization
	void Start () {
        source = gameObject.GetComponent<AudioSource>();//再生オブジェクト特定
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Yougan")
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);//一時的に残留してオブジェクトを再生する
            Destroy(gameObject);  
        }
    }

}
