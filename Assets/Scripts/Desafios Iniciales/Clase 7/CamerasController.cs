using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController: MonoBehaviour
{
    [SerializeField] private GameObject followCharacter;

    [SerializeField] private GameObject lookCharacter;

    [SerializeField] private GameObject frontCharacter;

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Here Z");

            followCharacter.SetActive(true);
            lookCharacter.SetActive(false);
            frontCharacter.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            Debug.Log("Here X");

            lookCharacter.SetActive(true);
            followCharacter.SetActive(false);
            frontCharacter.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.C))
        {

            Debug.Log("Here C");

            frontCharacter.SetActive(true);
            lookCharacter.SetActive(false);
            followCharacter.SetActive(false);

        }

    }
}
