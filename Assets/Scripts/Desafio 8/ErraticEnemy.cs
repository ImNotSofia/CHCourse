using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErraticEnemy : MonoBehaviour
{

    public enum StateOfEnemy {LookAt, Chasing}

    private EnemyChaser enemyChaser;

    private EnemyLowLook enemyLowLook;

    public float speedToSee;

    public float speed;

    [SerializeField] private float distanceMax = 2;

    [SerializeField] private Transform mainCh;

    public StateOfEnemy states;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SetEnemyState(states);

    }


    private void SetEnemyState(StateOfEnemy states)
    {

        switch (states)
        {

            case StateOfEnemy.LookAt:
                LookAt();
                break;

            case StateOfEnemy.Chasing:
                Chasing();
                break;
            default:
                Debug.Log("Something goes wrong");
                break;
        }


    }

    private void LookAt()
    {

        Quaternion newRotation = Quaternion.LookRotation((mainCh.position - transform.position));

        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToSee * Time.deltaTime);

    }

    private void Chasing()
    {

        var toMain = mainCh.position - transform.position;

        var distance = toMain.magnitude;

        if (distance > distanceMax)
        {

            transform.position = Vector3.MoveTowards(transform.position, mainCh.position, Time.deltaTime * speed);

        }

    }

}
