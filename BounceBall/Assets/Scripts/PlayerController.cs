using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Components Connected to the same gameObject as this one.
    Transform myTran;
    CapsuleCollider myCol;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //init my components
        myTran = GetComponent<Transform>();
        myCol = GetComponent<CapsuleCollider>();

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
}
