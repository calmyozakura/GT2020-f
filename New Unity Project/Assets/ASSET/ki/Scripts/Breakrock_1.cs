using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakrock_1 : MonoBehaviour
{
    public GameObject iwa;
    public GameObject part1;
    public GameObject part2;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (iwa==null)
        {
            part1.gameObject.SetActive(true);
            part2.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Attack")
        {

            Destroy(iwa.gameObject);//デストロイ
            part1.gameObject.SetActive(true);
            part2.gameObject.SetActive(true);


        }
    }
}
