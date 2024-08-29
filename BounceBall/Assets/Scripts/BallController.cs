using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //Components Connected to the same gameObject as this one.
    Transform myTran;

    //Components Connected to other gameObjects.
    Transform camTran;

    // Start is called before the first frame update
    void Start()
    {
        //init my components
        myTran = GetComponent<Transform>();

        //init other components
        camTran = GameObject.Find("Main Camera").GetComponent<Transform>();        

        //myTran.position = new Vector3(-2, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Called when my gameObject collides with another
    //Requires at least 1 of the gameObjects to have a Rigidbody.
    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        //Do Stuff
        //camTran.position += new Vector3(0, 0, -1);
    }    
}
