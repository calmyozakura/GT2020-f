using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour {
    [SerializeField] private GameObject PlayerHP;
    life script;

	// Use this for initialization
	void Start () {
        script = PlayerHP.GetComponent<life>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
