using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesafioGenerico5 : MonoBehaviour
{
    [SerializeField] private GameObject thirdPersonCamera;

    [SerializeField] private GameObject sideCamera;

    [SerializeField] private GameObject castleCamera;

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

            thirdPersonCamera.SetActive(true);
            castleCamera.SetActive(false);
            sideCamera.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            Debug.Log("Here X");

            castleCamera.SetActive(true);
            thirdPersonCamera.SetActive(false);
            sideCamera.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.C))
        {

            Debug.Log("Here C");

            sideCamera.SetActive(true);
            castleCamera.SetActive(false);
            thirdPersonCamera.SetActive(false);

        }



    }
}
