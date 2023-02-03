using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float speed;

    public Vector3 direction;

    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {

            transform.localScale *= 2;

        }

    }
    



    private void Movement()
    {

        transform.position += direction * speed;

    }
}
