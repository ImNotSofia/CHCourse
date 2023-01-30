using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErraticEnemy : MonoBehaviour
{

    public enum StateOfEnemy {LookAt, Chasing}

    private EnemyChaser enemyChaser;

    private EnemyLowLook enemyLowLook;

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

        enemyLowLook.LookCharacter();

    }

    private void Chasing()
    {

        enemyChaser.Persecute();

    }

}
