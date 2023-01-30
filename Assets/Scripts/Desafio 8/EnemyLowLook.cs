using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLowLook : MonoBehaviour
{

    [SerializeField] private float speedToSee;
    [SerializeField] private Transform mainCh;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        LookCharacter();
    }

    public void LookCharacter()
    {

        Quaternion newRotation = Quaternion.LookRotation((mainCh.position - transform.position));

        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToSee * Time.deltaTime);

    }
}
