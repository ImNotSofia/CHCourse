using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public GameObject Bullet;

    public Transform pOfShoot; //El POfShoot fue hecho para que se disparase desde el cañon, no se porqué pero no funciona, en cambio si dejo solo el instantiate funciona de maravilla????

    public float speed;

    public float moveTempo;

    public float moveTempoRest;

    public float destroyTempo;

    public float destroyTempoLeft;

    public GameObject cloneBullet;

    private void Start()
    {

        ResetTempo();

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {

            Shoot();

        }

        //if (Input.GetKeyDown(KeyCode.Scape))
        //{

        //    Polymorf();

        //}

        Tempo();

        DestroyBullet();

    }

    //private void Polymorf()
    //{

    //    cloneBullet.scale += cloneBullet.scale;
    //}



    private void Shoot()
    {
        Debug.Log("Shoot");

        cloneBullet = Instantiate(Bullet);
    }

    private void ResetTempo()
    {

        moveTempo = moveTempoRest;

    }

    private void ResetTempoD()
    {

        destroyTempo = destroyTempoLeft;

    }

    private void Tempo()
    {

        moveTempo -= Time.deltaTime;

        if (moveTempo <= 0) {

            Shoot();
            ResetTempo();

        }

    }

    private void DestroyBullet()
    {

        destroyTempo -= Time.deltaTime;

        if (destroyTempo <= 0) {

            Destroy(cloneBullet);
            ResetTempoD();

        }
        

    }

}
