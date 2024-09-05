using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Components Connected to the same gameObject as this one.
    Transform myTran;
    CapsuleCollider myCol;

    //Components Connected to other gameObjects.
    Text scoreTxt;

    public float speed;

    // private property
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        //init my components
        myTran = GetComponent<Transform>();
        myCol = GetComponent<CapsuleCollider>();

        //init other components
        scoreTxt = GameObject.Find("ScoreMsg").GetComponent<Text>();

        //init private properties
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(h, 0, 0);
        myTran.position += speed * dir * Time.deltaTime; // * (1/60)

        if(Input.GetButtonDown("Jump")) {
            //myCol.radius = 2.0f;
        }
    }

    //Called when my gameObject collides with another
    //Requires at least 1 of the gameObjects to have a Rigidbody.
    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;

        score += 10;
        scoreTxt.text = "Score: " + score;
    }
}
