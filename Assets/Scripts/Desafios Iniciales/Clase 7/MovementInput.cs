using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
    public float speed = 1.0f;

    //private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            Debug.Log("W here!");

            transform.position += Vector3.back * speed;


        }

        if (Input.GetKey(KeyCode.S))
        {

            Debug.Log("S here!");

            transform.position += Vector3.forward * speed;

        }

        if (Input.GetKey(KeyCode.A))
        {

            Debug.Log("A here!");

            transform.position += Vector3.right * speed;

        }

        if (Input.GetKey(KeyCode.D))
        {

            Debug.Log("D here!");

            transform.position += Vector3.left * speed;

        }

    }

}
