using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //Components Connected to the same gameObject as this one.
    Transform myTran;
    Rigidbody myBod;
    AudioSource myAudio;

    //Components Connected to other gameObjects.
    Transform camTran;
    Text scoreTxt;

    //public properties
    public AudioClip bounceSound; //Initialised in the inspector.

    // private property
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        //init my components
        myTran = GetComponent<Transform>();
        myBod = GetComponent<Rigidbody>();
        myAudio = GetComponent<AudioSource>();

        //init other components
        camTran = GameObject.Find("Main Camera").GetComponent<Transform>();
        scoreTxt = GameObject.Find("ScoreMsg").GetComponent<Text>();

        //myTran.position = new Vector3(-2, 5, 0);
        float f = Random.Range(-1f, 1f);
        myBod.velocity = new Vector3(f, 5, 0);

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && Time.timeScale == 0) {
            Time.timeScale = 1;
            SceneManager.LoadScene(0); // (re)load a scene.
        }
    }

    //Called when my gameObject collides with another
    //Requires at least 1 of the gameObjects to have a Rigidbody.
    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        //Do Stuff
        //camTran.position += new Vector3(0, 0, -1);
        myAudio.PlayOneShot(bounceSound);

        score += 10;
        scoreTxt.text = "Score: " + score;
    }

    //Called when my gameObject overlaps (triggers) with another
    //Requires at least 1 of the gameObjects to have a Rigidbody or CharacterController.
    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        //Do Stuff

        Time.timeScale = 0;
    }    
}
