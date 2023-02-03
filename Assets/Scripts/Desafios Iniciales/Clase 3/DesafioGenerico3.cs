using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesafioGenerico3 : MonoBehaviour
{

    public string characterName = "Steve";

    public float characterHealth = 100;

    public string yourName;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Tu nombre es " + characterName);

        ChangeName(); 
        
        Debug.Log("Cargando...");

        Debug.Log("Tu nuevo nombre es " + characterName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeName()
    {

        characterName= yourName;

    }

}
