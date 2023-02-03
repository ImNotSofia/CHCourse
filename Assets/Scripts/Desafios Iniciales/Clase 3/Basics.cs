using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{

    public float healthCharacter = 100f;

    public float speed;

    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Tu vida es de " + healthCharacter);

        TakeDamage();

        Debug.Log("¡Oh no! Has recibido daño");

        Debug.Log("Tu vida es actual de " + healthCharacter);

        MagicPotion();

        Debug.Log("¡Te curaste!");

        Debug.Log("Tu vida es actual de " + healthCharacter);

    }

    // Update is called once per frame

    void Update()
    {

        Movement();

    }

    private void Movement()
    {

        transform.position += direction * speed;

    }

    private void TakeDamage()
    {

        healthCharacter -= 5;

    }

    private void MagicPotion()
    {

        healthCharacter += 1.5f;

    }
}
