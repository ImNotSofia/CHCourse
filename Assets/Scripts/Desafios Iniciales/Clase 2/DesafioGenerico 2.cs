using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DesafioGenerico2 : MonoBehaviour
{

    public string characterName = "Steve";

    public int levelCharacter = 0;

    private float healtCharacter = 99.9f; //Números con coma

    private double manaCharacter = 265.87d; //Números con coma aún más exactos

    [SerializeField] private bool characterLifeStatus = true; //Is alive


    //All types:


    public long levelMax = 999999999; //Integer pero más largo

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
