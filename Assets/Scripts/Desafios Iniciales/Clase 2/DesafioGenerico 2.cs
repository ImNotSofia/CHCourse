using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DesafioGenerico2 : MonoBehaviour
{

    public string characterName = "Steve";

    public int levelCharacter = 0;

    private float healtCharacter = 99.9f; //N�meros con coma

    private double manaCharacter = 265.87d; //N�meros con coma a�n m�s exactos

    [SerializeField] private bool characterLifeStatus = true; //Is alive


    //All types:


    public long levelMax = 999999999; //Integer pero m�s largo

    public char aInitial = 'S'; //String pero de un solo caracter



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
