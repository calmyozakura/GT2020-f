using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakrock_1 : MonoBehaviour
{
    public GameObject iwa;
    public GameObject part;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (iwa==null)
        {
            part.gameObject.SetActive(true);

        }
    }
}
