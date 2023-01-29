using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script0 : MonoBehaviour
{

    public string characterName;

    public int characterAge;

    public float characterHealth;

    public float characterDefense;

    //public float damage;

    public bool useRayTracing;

    [SerializeField] private double physicsFall;

    private Vector2 xy;

    private Vector3 thirdPosition;

    [SerializeField] private EnemyScript enemyScript;

    public float healthPotion = 1.5f;

    void Awake()
    {

        characterHealth = 100;

        characterDefense = 2.5f;

        characterName = "Steve";

    }


    // Start is called before the first frame update
    void Start()
    {

            //Debug.Log("Life is " + characterHealth);


    }

    // Update is called once per frame
    void Update()
    {

        //Hurting();

        //Debug.Log("Actual life is " + characterHealth);

        //Health();

        //Debug.Log("Actual life is " + characterHealth);

    }

    
    //private void Health()
    //{

      //  characterHealth += healthPotion;

    //}

    //private void Hurting()
    //{

      //  characterHealth -= enemyScript.damage - characterDefense;

    //}


}
