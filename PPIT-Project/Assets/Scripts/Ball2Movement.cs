using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Movement : MonoBehaviour
{

     private Rigidbody rigidB;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
         rigidB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            rigidB.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            rigidB.AddForce(Vector3.back * speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidB.AddForce(Vector3.right *speed);
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            rigidB.AddForce(Vector3.left *speed);
        }
        
    }
}
