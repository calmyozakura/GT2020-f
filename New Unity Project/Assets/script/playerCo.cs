using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerCo : MonoBehaviour{

    private Rigidbody rB;
    private Vector3 rbVelo;

    public Text goalText;
    public bool goalOn;
    private Vector3 height;

    // Use this for initialization
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        goalText.enabled = false;
        goalOn = false;
        //   failText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goalOn == false)
        {
            rbVelo = Vector3.zero;
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            rbVelo = rB.velocity;
        }
        height = this.GetComponent<Transform>().position;
        if (height.y <= -3.0f)
        {
            // explosion.transform.position = this.transform.position;
            // explosion.play();
            this.gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            other.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
            rB.AddForce(-rbVelo.x * 0.8f, 0, -rbVelo.z * 0.8f, ForceMode.Impulse);
            goalText.enabled = true;
            goalOn = true;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Kill")
        {
            //  explosion.transform.position = this.transform.position;
            this.gameObject.SetActive(false);
            //  Debug.Log(explosion.name);
            // failText.enabled = true;
            // explosion.Play();
            
        }
    }
}

