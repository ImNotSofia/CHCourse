using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCleanScript : MonoBehaviour
{

    [SerializeField] private Vector3 direction;

    [SerializeField] private Vector3 scale;

    // Start is called before the first frame update
    void Start()
    {

        transform.localScale = scale;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += direction;

    }
}
