using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterD8 : MonoBehaviour
{

    public float speed;

    public Vector3 direction;

    public float speedToSee;

    // Start is called before the first frame update
    void Start()
    {

        transform.position += direction * speed;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            //Debug.Log("Working A");

            Quaternion rotation = Quaternion.Euler(0, 15, 0);

            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //Debug.Log("Working D");

            Quaternion rotation = Quaternion.Euler(0, -15, 0);

            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speed * Time.deltaTime);

        }


    }
}
