using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCleanScriptD2 : MonoBehaviour
{

    public float characterHealth;

    public float speed;

    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

        characterHealth = 100;

        Debug.Log("Initial life is: " + characterHealth);

        Hurting();

        Debug.Log("Actual life is: " + characterHealth);

        Health();

        Debug.Log("Actual life is: " + characterHealth);

    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        
    }

    private void Health()
    {

        characterHealth += 1.5f;

    }

    private void Hurting()
    {

        characterHealth -= 5f;

    }

    private void Movement()
    {

        transform.position += direction;

    }
}
