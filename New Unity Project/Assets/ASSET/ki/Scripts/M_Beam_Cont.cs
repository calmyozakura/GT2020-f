using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Beam_Cont : MonoBehaviour
{
    public GameObject M_Beam;
    public GameObject Dino;

    private Vector3 M_B_posi;
    private Vector3 Dino_Posi;
    public Vector3 Offset;

    // Use this for initialization
    void Start()
    {
        M_B_posi = M_Beam.transform.position;
        Dino_Posi = Dino.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            M_Beam.SetActive(false);
            Dino_Posi = Dino.transform.position;
            M_Beam.transform.position = Dino_Posi + Offset;
            M_Beam.SetActive(true);

        }
    }
}
