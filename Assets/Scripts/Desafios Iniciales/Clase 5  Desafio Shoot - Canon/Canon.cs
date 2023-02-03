using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{ 

    [SerializeField] private GameObject Bullet;

    [SerializeField] private GameObject CanonAIM;

    public GameObject cloneBullet;

    public float destroyTempo;

    public float restDestroyTempo;

    public float tempo;

    public float restTempo;

    private void Start()
    {

        Resetear();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

            Shoot();

        }

        //if (Input.GetKeyDown(KeyCode.J))
        //{
        //    Invoke("Shoot", 1.0f);

        //    Invoke("Shoot", 2.0f);

        //}

        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    Invoke("Shoot", 1.0f);

        //    Invoke("Shoot", 2.0f);

        //    Invoke("Shoot", 3.0f);
        //}

        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    Invoke("Shoot", 1.0f);

        //    Invoke("Shoot", 2.0f);

        //    Invoke("Shoot", 3.0f);

        //    Invoke("Shoot", 4.0f);
        //}

        Activar();

        DestroyBullet();

    }

    private void Shoot()
    {

        cloneBullet = Instantiate(Bullet, CanonAIM.transform);

        Debug.Log("Shoot");

    }


    private void Resetear()
    {

        tempo = restTempo;

    }

    private void Activar()
    {

        tempo -= Time.deltaTime;

        if (tempo <= 0)
        {

            Shoot();

            Resetear();

        }

    }

    private void DestroyBullet()
    {

        destroyTempo -= Time.deltaTime;

        if (destroyTempo <= 0)
        {

            Destroy(cloneBullet);

            destroyTempo = restDestroyTempo;

        }
    }
}
