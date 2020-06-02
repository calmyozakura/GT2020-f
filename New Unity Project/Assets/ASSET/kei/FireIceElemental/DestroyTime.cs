using UnityEngine;
using System.Collections;

public class DestroyTime : MonoBehaviour {

	public float  T = 1;
	void Start () {
		Invoke("Destroy",T);
	}

	void Destroy(){
		Destroy(gameObject);
	}

}
