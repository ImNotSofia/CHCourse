using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaser : MonoBehaviour
{

    [SerializeField] private float distanceMax = 2;
    [SerializeField] private Transform mainCh;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Persecute();

    }

    public void Persecute()
    {

        var toMain = mainCh.position - transform.position;

        var distance = toMain.magnitude;

        if (distance > distanceMax) {

            transform.position = Vector3.MoveTowards(transform.position, mainCh.position, Time.deltaTime * speed);

        }

    }
}
