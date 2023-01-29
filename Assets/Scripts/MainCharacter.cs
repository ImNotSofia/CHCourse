using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{

    public string characterName;

    public int characterAge;

    public float characterHealth;

    public float characterDefense;

    //public float speed;

    public float scaleZ = 0.1f;

    public float scaleY;

    public float scaleX;

    //public float direction;

    [SerializeField] private EnemyScript enemyScript;

    [SerializeField] private Vector3 movement;

    public float healthPotion;

    public bool w;

    public bool a;

    public bool s;

    public bool d;

    // Start is called before the first frame update
    void Start()
        //Seteo valores predeterminados al iniciar.
    {

        characterName = "Steve";

        characterAge = 20;
    
        characterHealth = 100;

        characterDefense = 10;

        healthPotion = 1.5f;

        //speed = 1;

        //direction = //wasdqe basically, depende de negativo y etc. ??? como hacer.

        Debug.Log("Life is " + characterHealth);

        Debug.Log("");

    }

    // Update is called once per frame
    void Update()
    {

        //Hurting();

        Debug.Log("Actual life is " + characterHealth);

        //Health();

        Debug.Log("Actual life is " + characterHealth);

        //transform.Translate(0, 0, speed);

        //transform.Translate(0, speed, 0);

        //transform.Translate(speed, 0, 0);

        //if (w == true){ 
        //    straightGO();
        //}

        //if (a == true){
        //    leftGO();
        //}

        //if (s == true){
        //    backGO();
        //}

        //if (d == true)
        //    rightGO();
        //}
    }
}


//private void Health()
//{

//    characterHealth += healthPotion;

//}

//private void Hurting()
//{

//    characterHealth -= enemyScript.damage - characterDefense;

//}

//private void Movement()
//{

//    transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

//    transform.Translate(0, 0, scaleZ);

//    transform.Translate(0, scaleY, 0);

//    transform.Translate(scaleX, 0, 0);

//}

//private void leftGO()
//{

//    transform.position += Vector3.left * Time.deltaTime;

//}

//private void rightGO()
//{

//    transform.position += Vector3.right * Time.deltaTime;

//}

//private void straightGO()
//{

//    transform.position += Vector3.forward * Time.deltaTime;

//}

//private void backGO()
//{

//    transform.position += Vector3.back * Time.deltaTime;

//}

