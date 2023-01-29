using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] private string enemyName;

    public float damage;

    [SerializeField] private Script0 script0;

    //[SerializeField] private Vector3 movement;

    public float speedZ;

    public float speedY;

    public float speedX;

    public float scaleZ;

    public float scaleY;

    public float scaleX;

    //public float damage;

    //default all scales 1

    //public float realAtk;


    // Start is called before the first frame update
    void Start()
    {
        //movement.set(0.24, 1.317, -7.88);

        //transform.position = (0, 1, -7f);

        //movement = 1; 

        //damage = 5;

        //script0.characterHealth -= damage - script0.characterDefense;

        //script0.characterHealth = realAtk - script0.characterHealth;

        //transform.Translate(0.24, 1.32, -7, 77);

        //transform.localScale = new Vector3(5, 5, 5); //WHYYYYYYYYYYYYY DIDN'T WORK HERE

    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

        transform.Translate(0, 0, speedZ);

        transform.Translate(0, speedY, 0);

        transform.Translate(speedX, 0, 0);

        //transform.Rotate(50*Time.deltaTime, 0, 0);

        //transform.Rotate(0, 50*Time.deltaTime, 0);        //SO FUNNY OMGGG

        //speedZ default = 0.1

    }
}
