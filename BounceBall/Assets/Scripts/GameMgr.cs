using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    //Components Connected to the same gameObject as this one.

    //Components Connected to other gameObjects.

    //public properties (initialized in the inspector)

    //private properties
    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        //init my components

        //init other components

        //init private properties
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver && Input.GetButtonDown("Fire1")) {
            if(Time.timeScale == 0) {
                Time.timeScale = 1;    
            }
            else {
                Time.timeScale = 0;
            }
        }

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
    }

    //Called when my gameObject overlaps (triggers) with another
    //Requires at least 1 of the gameObjects to have a Rigidbody or CharacterController.
    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        if(otherGO.name == "Ball") {
            Time.timeScale = 0;
            gameOver = true;
        }
    }
}